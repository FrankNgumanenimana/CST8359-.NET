using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Lab1
{
    class Program
    {
        private static IList<string> listWords = new List<string>();

        static void Main(string[] args)
        {

            string option;
            bool inOrExit = true;
            Console.WriteLine("\n Hey Welcome :) \n");
            while (inOrExit == true)
            {
                Menu();
                option = Console.ReadLine();
                switch (option)
                {
                    case null:
                        goto case default;
                    case "1":
                        ImportFile();
                        break;
                    case "2":
                        BubbleSort(listWords);
                        break;
                    case "3":
                        sortLinqLambda(listWords);
                        break;
                    case "4":
                        DistinctWords(listWords);
                        break;
                    case "5":
                        tenFirst(listWords);
                        break;
                    case "6":
                        startJ(listWords);
                        break;
                    case "7":
                        endsD(listWords);
                        break;
                    case "8":
                        greaterThanFour(listWords);
                        break;
                    case "9":
                        startAlessThanThree(listWords);
                        break;
                    case "x":
                        Console.WriteLine("Exit the program");
                        inOrExit = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You have entered Wrong Choice or Null!! \n Please try again: ");
                        break;
                }
            }

            void Menu()
            {
                Console.WriteLine("\nPlease Choose an option from the menu down below:");
                Console.WriteLine("1 - Import Words from File \n2 - Bubble Sort words \n3 - LINQ / Lambda sort words \n4 - Count the Distinct Words \n5 - Take the first 10 words ");
                Console.WriteLine("6 - Get the number of words that start with 'j' and display the count \n7 - Get and display of words that end with 'd' and display the count");
                Console.WriteLine("8 - Get and display of words that are greater than 4 characters long, and display the count ");
                Console.WriteLine("9 - Get and display of words that are less than 3 characters long and start with the letter 'a', and display the count \nx – Exit ");
                Console.Write("Enter your choice from the menu...");
            }

        }
        static void ImportFile()
        {
            //Reading the text file first
            int count = 0;//Dectecting the line starting from 0
            string line;//Store the string on line
            System.IO.StreamReader file = new System.IO.StreamReader("\\Words.txt");
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                listWords.Add(line);
                count = count + 1; ;
            }
            //Console.WriteLine(String.Join(" , ", words));//Printing the list
            Console.WriteLine("\nThe method found: " + count + " lines.\n");
        }



        private static IList<string> BubbleSort(IList<string> words)
        {
            Stopwatch timer;
            timer = Stopwatch.StartNew();
            for (int previous = 0; previous < (words.Count - 1); previous++)//get first element as Count is Lenght
            {
                for (int next = previous + 1; next < words.Count; next++)//gets second element which is i+1
                {
                    //if the second string is bigger than the first it returns a negative number which means swap the strings
                    if (string.Compare(words[next], words[previous]) < 0)
                    {
                        //The idea is to swap the bigger string(next) to the smaller(previous)
                        string tempString = words[next];
                        words[next] = words[previous];
                        words[previous] = tempString;

                    }
                }
            }

            timer.Stop();
            Console.WriteLine("\nElapsed Time: {" + timer.ElapsedMilliseconds + "} ms \n");
            //Console.WriteLine(String.Join(" , ", words));

            return words;
        }

        private static IList<string> sortLinqLambda(IList<string> words)
        {
            Stopwatch timer;
            timer = Stopwatch.StartNew();
            //LINQ to create a new list which contains the original values but sorted:
            // from x in words orderby x;
            var sortedListQ = words.OrderBy(w => w).ToList();
            words = sortedListQ;
            timer.Stop();
            Console.WriteLine("\nElapsed Time: {" + timer.ElapsedMilliseconds + "} ms\n");
            //Console.WriteLine(String.Join(" , ", words));
            return words;
        }

        static void DistinctWords(IList<string> words)
        {
            //count all the distinct words
            int totalDWords = (from w in words select w).Distinct().Count();
            Console.WriteLine("\nThe program found: " + totalDWords + " distinct words.\n");
        }
        static void tenFirst(IList<string> words)
        {
            int counting = 0;
            var result = words.Take(10);
            Console.WriteLine("\nThe 10 first words are:");
            foreach (string eachWord in result)
            { // Loop through List with for
                Console.WriteLine(((counting + 1) + " is: " + eachWord));
                counting++;
            }
        }
        static void startJ(IList<string> words)
        {
            int counting = 0;
            var search = words.Where(w => w.StartsWith("j")).ToList();
            //Console.WriteLine("\n");
            foreach (string eachWord in search)
            { // Loop through List with for
                Console.WriteLine((counting + 1) + " is: " + eachWord);
                counting++;
            }
            Console.WriteLine("The number of words that start with ‘j’ is:" + counting);
        }
        static void endsD(IList<string> words)
        {
            int counting = 0;
            var search = words.Where(w => w.EndsWith("d")).ToList();
            //Console.WriteLine("\n");
            foreach (string eachWord in search)
            { // Loop through List with for
                Console.WriteLine((counting + 1) + " is: " + eachWord);
                counting++;
            }
            Console.WriteLine("The number of words that start with ‘d’ is:" + counting);
        }
        static void greaterThanFour(IList<string> words)
        {
            int counting = 0;
            var search = words.Where(w => w.Length > 4).ToList();
            //Console.WriteLine("\n");
            foreach (string eachWord in search)
            { // Loop through List with for
                Console.WriteLine((counting + 1) + " is: " + eachWord);
                counting++;
            }
            Console.WriteLine("The number of words that are greater than 4 in lenght are:" + counting);
        }
        static void startAlessThanThree(IList<string> words)
        {
            int counting = 0;
            var search = words.Where(w => w.StartsWith("a") && w.Length < 3).ToList();
            //Console.WriteLine("\n");
            foreach (string eachWord in search)
            { // Loop through List with for
                Console.WriteLine((counting + 1) + " is: " + eachWord);
                counting++;
            }
            Console.WriteLine("The number of words that start with ‘a’ and have length less tha 3 is:" + counting);
        }
    }
}