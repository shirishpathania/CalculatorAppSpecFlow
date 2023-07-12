using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppSpecFlow
{
    internal class CalculatorLogic
    {
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }

        public int actualResult;

        public int Add()
        {
            actualResult = firstNumber + secondNumber;
            return actualResult;
        }

        public int Subtract()
        {
            actualResult = firstNumber - secondNumber;
            return actualResult;
        }

        public int Multiply()
        {
            actualResult = firstNumber * secondNumber;
            return actualResult;
        }

        public int Divide()
        {
            actualResult = firstNumber / secondNumber;
            return actualResult;
        }
    }
}
