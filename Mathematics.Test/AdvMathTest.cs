using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mathematics.Test
{
    public class AdvMathTest
    {
        [Fact]
        public void TestArea()
        {
            var math = new AdvMath();
            var results = math.CalcArea(10, 7);
            Assert.True(results == 70);
        }

        [Fact]
        public void TestAvg()
        {
            var math = new AdvMath();
            double[] myList = { 2, 2, 2, 2, 2, 2 };
            var results = math.CalcAverage(myList);
            Assert.True(results == 2);
        }

        [Fact]
        public void TestSquare()
        {
            var math = new AdvMath();
            var results = math.SquareNum(30);
            Assert.True(results == 900);
        }

        [Fact]
        public void TestPyTheo()
        {
            var math = new AdvMath();
            var results = math.PyTheorem(9, 12);
            Assert.True(results == 15);
        }




    }
}
