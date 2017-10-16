using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab
{
    public class CalculatorLogic : ICalculator
    {
        public string NumberOnScreen { get { return _numberOnScreen.ToString(); } }

        private double _numberOnScreen=0;

        private bool _dotActive=false;

        private int _stAfterDot=0;

        private void ClrearNumbOnScreen()
        {
            _dotActive = false;
            _numberOnScreen = 0;
            _stAfterDot = 0;
        } 

        public void TabNumber(int n)
        {
            if (n < 10 && n >= 0)
            {
                if (!_dotActive)
                {
                    _numberOnScreen *= 10;
                    _numberOnScreen += n;
                }
                else
                {
                    _stAfterDot++;
                    _numberOnScreen += Math.Pow(10, -_stAfterDot)*n;
                }
            }
        }

        public void DotActivate()
        {
            _dotActive = true;
        }

        public void Summation()
        {

        }

        public void Subtraction()
        {

        }

        public void Division()
        {

        }

        public void Multiplication()
        {

        }

        public void Equality()
        {

        }
    }
}
