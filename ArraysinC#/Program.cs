using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysinC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city1 = "Warsaw";
            string city2 = "London";
            string city3 = "Hongkong";
            string[] cities = new string[4];

            cities[0] = city1;
            cities[1] = city2;
            cities[2] = city3;
            cities[3] = "Singapour";
            cities[1] = "Berlin"; 
            int arrayLength = cities.Length; 
            Console.WriteLine(cities[0]);
            Console.WriteLine(cities[2]);
            int[] numbers = new int[2];
            Console.WriteLine(numbers[0]);
            bool[] boolArray = new bool[2];
            int?[] numbers1 = new int?[2];
            int[] numbers2 = new int[3] { 4, 5, 7 };
            int[] numbers3 = { 4, 5, 7 };
            bool?[] boolArray2 = { true, false, true };
            char[] characters = { 'a', 'b', 'c' };
            
            Console.ReadLine()

        }
    }
}
