using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Lab5.Models;
using Microsoft.AspNetCore.Http;
using Azure.Storage.Blobs;
using System.IO;
using Azure;

namespace Lab5.Controllers
{
    public class AnswerImagesController : Controller
    {
        private readonly AnswerImageDataContext _context;
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string earthContainerName = "earthimages";
        private readonly string computerContainerName = "computerimages";
        private readonly string containerName = "earthimages";

        public AnswerImagesController(AnswerImageDataContext context, BlobServiceClient blobServiceClient)
        {
            _context = context;
            _blobServiceClient = blobServiceClient;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.AnswerImages.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upload(IFormFile answerImage, string question)
        {

            BlobContainerClient containerClient;
            // Create the container and return a container client object
            try
            {
                containerClient = await _blobServiceClient.CreateBlobContainerAsync(containerName);
                // Give access to public
                containerClient.SetAccessPolicy(Azure.Storage.Blobs.Models.PublicAccessType.BlobContainer);
            }
            catch (RequestFailedException)
            {
                containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            }


            try
            {
                // create the blob to hold the data
                var blockBlob = containerClient.GetBlobClient(answerImage.FileName);
                if (await blockBlob.ExistsAsync())
                {
                    await blockBlob.DeleteAsync();
                }

                using (var memoryStream = new MemoryStream())
                {
                    // copy the file data into memory
                    await answerImage.CopyToAsync(memoryStream);

                    // navigate back to the beginning of the memory stream
                    memoryStream.Position = 0;

                    // send the file to the cloud
                    await blockBlob.UploadAsync(memoryStream);
                    memoryStream.Close();
                }

                // add the photo to the database if it uploaded successfully
                var image = new AnswerImage();
                image.Url = blockBlob.Uri.AbsoluteUri;
                image.FileName = answerImage.FileName;
                //Associating the option entered or answer to picture
                if (question == "Computer")
                    image.Question = Question.Computer;
                
                else
                    image.Question = Question.Earth;
                
                _context.AnswerImages.Add(image);
                _context.SaveChanges();
            }
            catch (RequestFailedException)
            {
                View("Error");
            }

            return RedirectToAction("Index");
        }

        // For multiple files, use this
        //public async Task<IActionResult> Create(ICollection<IFormFile> files)
        //{

        //    BlobContainerClient containerClient;
        //    // Create the container and return a container client object
        //    try
        //    {
        //        containerClient = await _blobServiceClient.CreateBlobContainerAsync(containerName);
        //        containerClient.SetAccessPolicy(Azure.Storage.Blobs.Models.PublicAccessType.BlobContainer);
        //    }
        //    catch (RequestFailedException e)
        //    {
        //        containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
        //    }

        //    foreach (var file in files)
        //    {
        //        try
        //        {
        //            // create the blob to hold the data
        //            var blockBlob = containerClient.GetBlobClient(file.FileName);
        //            if (await blockBlob.ExistsAsync())
        //            {
        //                await blockBlob.DeleteAsync();
        //            }

        //            using (var memoryStream = new MemoryStream())
        //            {
        //                // copy the file data into memory
        //                await file.CopyToAsync(memoryStream);

        //                // navigate back to the beginning of the memory stream
        //                memoryStream.Position = 0;

        //                // send the file to the cloud
        //                await blockBlob.UploadAsync(memoryStream);
        //                memoryStream.Close();
        //            }

        //            // add the photo to the database if it uploaded successfully
        //            var image = new Smiley();
        //            image.Url = blockBlob.Uri.AbsoluteUri;
        //            image.FileName = file.FileName;

        //            _context.Smilies.Add(image);
        //            _context.SaveChanges();
        //        }
        //        catch (RequestFailedException e)
        //        {

        //        }
        //    }
        //    return RedirectToAction("Index");
        //}

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.AnswerImages
                .FirstOrDefaultAsync(m => m.AnswerImageId == id);
            if (image == null)
            {
                return NotFound();
            }

            return View(image);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var image = await _context.AnswerImages.FindAsync(id);


            BlobContainerClient containerClient;
            // Get the container and return a container client object
            try
            {
                containerClient = _blobServiceClient.GetBlobContainerClient(earthContainerName);
            }
            catch (RequestFailedException)
            {
                return View("Error");
            }

            try
            {
                // Get the blob that holds the data
                var blockBlob = containerClient.GetBlobClient(image.FileName);
                if (await blockBlob.ExistsAsync())
                {
                    await blockBlob.DeleteAsync();
                }

                _context.AnswerImages.Remove(image);
                await _context.SaveChangesAsync();

            }
            catch (RequestFailedException)
            {
                return View("Error");
            }

            return RedirectToAction("Index");
        }

    }
}
