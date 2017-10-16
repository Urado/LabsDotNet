using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab
{
    public interface ICalculator
    {
        string NumberOnScreen { get; }

        void TabNumber(int n);

        void DotActivate();

        void Plus();

        void Summation();

        void Subtraction();

        void Division();

        void Multiplication();

        void Equality();
    }
}
