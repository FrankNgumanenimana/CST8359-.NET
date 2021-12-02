using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class Person
    {
        [Required]
        [StringLength(255)]

        public string firstName
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        public string lastName
        {
            get;
            set;
        }

        [Required]
        [Range(0, 200)]
        public int age
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string emailAddress
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        [DataType(DataType.Date)]
        public string dateOfBirth

        {
            get;
            set;
        }
        [Required]
        [StringLength(100)]
        [BindProperty(Name = "pass")]
        public string password
        {
            get;
            set;
        }

        [Required]
        [StringLength(255)]
        public string description
        {
            get;
            set;
        }

    }
}
