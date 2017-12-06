using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLab
{
    public class CalculatorLogic : ICalculator
    {
        public string NumberOnScreen { get { return (_numberOnScreen*_sign).ToString("G10"); } }

        private Func<double,double,double> Operation = Sum;

        private double _numberOnScreen = 0;

        private double _tmpNumber = 0;

        private int _sign = 1;

        private bool _isSomethingInTmp = false;

        private bool _isAnsver = false;

        private bool _dotActive = false;

        private int _stAfterDot = 0;

        private void ClearTmp()
        {
            _isSomethingInTmp = false;
        }

        private void ToTmp(double numberToTmp)
        {
            _isSomethingInTmp = true;
            _tmpNumber = numberToTmp;
            _isAnsver = true;
        }

        private void ClrearNumbOnScreen()
        {
            _isAnsver = false;
            _dotActive = false;
            _numberOnScreen = 0;
            _stAfterDot = 0;
            _sign = 1;
        }

        private void DoOpetor()
        {
            _numberOnScreen = _isSomethingInTmp ? Operation(_tmpNumber, _numberOnScreen*_sign) : _numberOnScreen * _sign;
            _sign = 1;
            ToTmp(_numberOnScreen);

        }

        public void TabNumber(int n)
        {
            if (_isAnsver)
                ClrearNumbOnScreen();
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
                    _numberOnScreen += Math.Pow(10, -_stAfterDot) * n;
                }
            }
        }

        public void DotActivate()
        {
            if (_isAnsver)
                ClrearNumbOnScreen();
            _dotActive = true;
        }

        public void Summation()
        {
            Operation = Sum;
            DoOpetor();
        }

        public void Subtraction()
        {
            Operation = Sub;
            DoOpetor();
        }

        public void Division()
        {
            Operation = Div;
            DoOpetor();
        }

        public void Multiplication()
        {
            Operation = Mul;
            DoOpetor();
        }

        public void Equality()
        {
            DoOpetor();
            ClearTmp();
        }

        public void Sqrt()
        {
            _numberOnScreen = Math.Sqrt(_numberOnScreen);
            _isAnsver = true;
        }

        public void C()
        {
            ClrearNumbOnScreen();
        }

        public void CE()
        {
            ClrearNumbOnScreen();
            ClearTmp();
        }

        public void Sign()
        {
            _sign *= -1;
        }

        private static Func<double, double, double> Sum = (x, y) => x + y;

        private static Func<double, double, double> Mul = (x, y) => x * y;

        private static Func<double, double, double> Div = (x, y) => x / y;

        private static Func<double, double, double> Sub = (x, y) => x - y;
    }
}
