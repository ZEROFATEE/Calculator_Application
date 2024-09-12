using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate double Formula(double arg1, double arg2);
    internal class CalculatorClass
    {
        private Formula _calculateEvent;
        public event Formula CalculateEvent
        {
            add
            {
                _calculateEvent += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                _calculateEvent -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }
        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }
}