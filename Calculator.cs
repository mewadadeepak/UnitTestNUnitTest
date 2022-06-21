using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator : ICalculator
    {
        public int Add(int Number1, int Number2)
        {
            return Number1 + Number2;
        }
        public int Substract(int Number1, int Number2)
        {
            return (Number1 - Number2);
        }
        public float Multiply(float Number1, float Number2)
        {
            return Number1 * Number2;
        }
        public float Divide(float Number1, float Number2)
        {
            return Number1 / Number2;
        }

        public static int mod(int Number1, int Number2)
        {
            return Number1 % Number2;
        }
    }
}
