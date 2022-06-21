using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public interface ICalculator
    {
        int Add(int Number1, int Number2);
        int Substract(int Number1, int Number2);
        float Multiply(float Number1, float Number2);
        float Divide(float Number1, float Number2);

    }
}