using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mathematics.Test
{
    public class BasicMathTest
    {
        [Fact]
        public void TestAddNumbers()
        {
            var math = new BasicMath();
            var results = math.AddNumbers(5, 5);
            Assert.True(results == 10);
        }
        [Fact]
        public void TestSubtractNumbers()
        {
            var math = new BasicMath();
            var r1 = math.SubtractNumbers(15, 5);
            Assert.True(r1 == 10);

        }

        [Fact]
        public void TestMultiplyNumbers()
        {
            var math = new BasicMath();
            var r2 = math.MultiplyNumbers(2, 5);
            Assert.True(r2 == 10);
        }
        [Fact]
        public void TestDivideNumbers()
        {
            var math = new BasicMath();
            var r3 = math.DivideNumbers(20, 2);
            Assert.True(r3 == 10);
        }
    }
}
