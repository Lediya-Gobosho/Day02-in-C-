using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] sigleDimensionArray = new string[3];

            string[,] twoDiemsionArray = new string[3, 2];
            string[][] jaggedArray = new string[3][];

            jaggedArray[0] = new string[2];
            jaggedArray[1] = new string[3] { "x", "y", "z" };
            jaggedArray[2] = new string[] { "u", "k" };

            int totalLength = jaggedArray.Length;  

            int specificInnerArrayLength = jaggedArray[1].Length; 


        }
    }
}
