using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class AdvMath
    {
        public double CalcArea(double height, double width)
        {
            return height * width;
        }

        public double CalcAverage(double[] myList)
        {
            var runTotal = 0.0;
            for(int i=0; i < myList.Length; i++)
            {
                runTotal += myList[i];
            }
            return runTotal / (myList.Length);
        }

        public double SquareNum(double num)
        {
            return num * num;
        }

        public double PyTheorem(double a, double b)
        {
            var newA = SquareNum(a);
            var newB = SquareNum(b);

            var c = Math.Sqrt(newA + newB);
            return c;
        }
    }
}
