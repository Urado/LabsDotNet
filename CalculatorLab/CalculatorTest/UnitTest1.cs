using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLab;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BaseTest()
        {
            ICalculator Calc = new CalculatorLogic();

            Assert.IsTrue(Calc.NumberOnScreen == "0");

            Calc.TabNumber(0);
            Calc.TabNumber(1);
            Calc.TabNumber(2);
            Calc.TabNumber(3);

            Assert.IsTrue(Calc.NumberOnScreen == "123");

            Calc.DotActivate();
            Calc.TabNumber(4);
            Calc.DotActivate();
            Calc.TabNumber(5);
            Calc.TabNumber(6);

            string s = Calc.NumberOnScreen;
            Assert.IsTrue(Calc.NumberOnScreen == "123,456");
        }
    }
}
