using Xunit;
using Tes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tes.Tests
{
    public class MyCalcTests
    {
        [Fact()]
        public void SumTest()
        {
            int x = -500;
            int y = 499;
            int expected = -1;

            MyCalc c = new MyCalc();

            int actual = c.Sum(x, y);

            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void MinTest()
        {
            int x = -5; int y = -5;
            int expected = 0;

            MyCalc c = new MyCalc();
            int actual = c.Min(x, y);
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void SquareRootTest_ValidInput()
        {
            double number = 9;
            double expected = 3;

            MyCalc calc = new MyCalc();
            double actual = calc.SquareRoot(number);

            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void SquareRootTest_NegativeInput_ThrowsException()
        {
            double number = -1;

            MyCalc calc = new MyCalc();

            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => calc.SquareRoot(number));
            Assert.Equal("Number must be non-negative. (Parameter 'number')", exception.Message);
        }

        [Fact()]
        public void SumTest_WithNegativeNumbers()
        {
            int x = -10;
            int y = -20;
            int expected = -30;

            MyCalc calc = new MyCalc();
            int actual = calc.Sum(x, y);

            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void IsPositiveTest_PositiveNumber()
        {
            int number = 10;

            MyCalc calc = new MyCalc();
            bool actual = calc.IsPositive(number);

            Assert.True(actual);
        }

        [Fact()]
        public void IsPositiveTest_NegativeNumber()
        {
            int number = -10;

            MyCalc calc = new MyCalc();
            bool actual = calc.IsPositive(number);

            Assert.False(actual);
        }

        [Fact()]
        public void IsPositiveTest_Zero()
        {
            int number = 0;

            MyCalc calc = new MyCalc();
            bool actual = calc.IsPositive(number);

            Assert.False(actual);
        }
    }
}