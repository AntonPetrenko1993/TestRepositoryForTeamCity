using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorTestProject.Tests
{
    [TestFixture]
    class CalculatorTest
    {
        private Calculator calculator;

        [SetUp]
        public void Init()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Sum_2_Plus_2_returned_4()
        {
            int expectedResult = 4;
            int actualResult = calculator.Sum(2, 2);

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void Sub_4_Minus_2_returned_2()
        {
            int expectedResult = 2;
            int actualResult = calculator.Sub(4, 2);

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void Mul_2_Multiply_2_returned_4()
        {
            int expectedResult = 4;
            int actualResult = calculator.Mul(2, 2);

            Assert.AreEqual(actualResult, expectedResult);
        }

        [Test]
        public void Div_4_Divide_2_returned_2()
        {
            int expectedResult = 2;
            int actualResult = calculator.Div(4, 2);

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
