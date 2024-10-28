using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tes
{
    public class MyCalc
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Min(int a, int b)
        {
            return a - b;
        }
        public double SquareRoot(double number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException(nameof(number), "Number must be non-negative.");
            return Math.Sqrt(number);
        }
        public bool IsPositive(int number)
        {
            return number > 0;
        }
    }
}
