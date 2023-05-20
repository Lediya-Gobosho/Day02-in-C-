using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cityArray = { "warsaw", "berlin", "paris" }; 
            string exampleString = "warsaw";
            char exampleChar = 'g';
            List<string> list = new List<string>(); 
            List<string> list2 = null; 
            list.Add("warsaw");
            list.Add("berlin");
            list.Insert(1, "paris");
            string city1 = list[0];
            string city3 = list[list.Count - 1]; 
            list.RemoveAt(1); 
            list.Remove("paris");  

           

        }
    }
}
