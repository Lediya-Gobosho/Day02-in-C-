using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClasses
{
    internal class Calculator
    {
        public int CalculateSum(int a, int b)
        {
            int c = a + b;

            return c;
        }

        public int CalculateDifference(int a, int b)
        {
            int c = a - b;
            return c;
        }
    }
}
