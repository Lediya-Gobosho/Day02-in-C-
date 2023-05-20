﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // spliting 
            string sentence = "How are you";

            string[] words = sentence.Split(' ');

            string sentence2 = "How!$are**you";

            string[] separators = { "!$", "**" };

            string[] words2 = sentence2.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // joining 

            string[] array = { "Warsaw", "Paris", "Berlin" };

            string result = string.Join(" - ", array);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
