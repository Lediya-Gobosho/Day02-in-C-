using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_Calculator
{
    internal class Calculator
    {
            public double? PerformOperation(int a, int b, char symbol)
            {
                string operation = Convert.ToString(symbol);

                return CalculateOperation(a, b, operation);
            }

            private double? CalculateOperation(int a, int b, string operation)
            {
                double? result = null;
                if (operation == "+")
                    result = a + b;
                else if (operation == "-")
                    result = a - b;
                else if (operation == "*")
                    result = a * b;
                else if (operation == "/")
                    result = Convert.ToDouble(a) / b;

                if (result != null)
                    return result;
                else
                    throw new Exception("cannot calculate the result");
            }

            public double? PerformOperation(string equation) 
            {
                string[] plusArr = equation.Split('+'); 
                string[] minusArr = equation.Split('-');  
                string[] multiplyArr = equation.Split('*'); 
                string[] divideArr = equation.Split('/');   

                string operation;
                int number1;
                int number2;

                if (plusArr.Length == 2) 
                {
                    number1 = Convert.ToInt32(plusArr[0]);
                    number2 = Convert.ToInt32(plusArr[1]);
                    operation = "+";
                }
                else if (minusArr.Length == 2) 
                {
                    number1 = Convert.ToInt32(minusArr[0]);
                    number2 = Convert.ToInt32(minusArr[1]);
                    operation = "-";
                }
                else if (minusArr.Length == 2)  
                {
                    number1 = Convert.ToInt32(multiplyArr[0]);
                    number2 = Convert.ToInt32(multiplyArr[1]);
                    operation = "*";
                }
                else 
                {
                    number1 = Convert.ToInt32(divideArr[0]);
                    number2 = Convert.ToInt32(divideArr[1]);
                    operation = "/";
                }
                return CalculateOperation(number1, number2, operation);
            }
        
    }
}
