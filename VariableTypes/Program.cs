using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VariableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            char b = 'a';
            string c = "Hello"; 
            double d = 5.6;
            bool e = false;

            WebClient wc = new WebClient();
            StringBuilder sb = new StringBuilder("very long string");

            int a1 = a;  
            StringBuilder sb2 = sb;
            DateTime dt = new DateTime(2023, 5, 5);
            DateTime dt2 = dt;
            
        }
    }
}
