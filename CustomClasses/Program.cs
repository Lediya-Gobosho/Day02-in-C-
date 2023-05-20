using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Calculator c1; 
            new Calculator();
            Calculator c2;
            c2 = new Calculator();
            int g1 = c.CalculateSum(3, 4);
            int g2 = c.CalculateDifference(4, 3);
            Console.WriteLine(g1);
            Console.WriteLine(g2);
            Console.ReadLine();

        }
    }
}
