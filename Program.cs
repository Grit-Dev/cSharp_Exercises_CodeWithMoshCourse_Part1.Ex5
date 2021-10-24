using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        

        public static void Exercise1()
        {
            //Write a program that reads a text file and displays the number of words

            int counter = 0;


            //**PLEASE NOTE: Enter in your own source file path int the file string**//
            //**********************************************************************//

            string file = @"C:\Users\Paulm\source\repos\ConsoleApp2\TextFile1.txt";
            
            //**********************************************************************//
         
            var text = File.ReadAllText(file);

            var textSA = text.Split(" ");

            foreach (var word in textSA)
            {
                counter++;
            }

            Console.WriteLine("Total number of words in the file is: " + counter + "\n");
     
        }

        public static void Exercise2()
        {
            //Write a program that reads a text file and displays the longest word in the file.

            string answer = "";
            string file = @"C:\Users\Paulm\source\repos\ConsoleApp2\TextFile1.txt";
            int holdmyValue = 0;
            int counter = 0;
            int max = 0;
            string longestWord = "";


            var text = File.ReadAllText(file);
            var stringSA = text.Split();


            foreach (var word2 in stringSA)
            {
                answer = word2;

                foreach (char chr in answer)
                {
                    holdmyValue = holdmyValue + counter++;

                    if (holdmyValue > max)
                    {
                        longestWord = answer;
                    }

                }
            }

            Console.WriteLine($"Longest word is: {longestWord}");

        }

        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
           
        }
    }
}
