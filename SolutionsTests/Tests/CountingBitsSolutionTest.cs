using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsTests.Tests
{
    public class CountingBitsSolutionTest
    {
        [Theory]
        [InlineData(2, new int[] { 0, 1, 1 })]
        [InlineData(5, new int[] { 0, 1, 1, 2, 1, 2 })]
        public void Test(int n, int[] expected)
        {
            var actual = CountingBitsSolution.CountBits(n);

            Assert.Equal(expected, actual);
        }
    }
}
