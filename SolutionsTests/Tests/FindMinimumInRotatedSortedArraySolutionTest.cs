using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsTests.Tests
{
    public class FindMinimumInRotatedSortedArraySolutionTest
    {
        [Theory]
        [InlineData(new int[] { 3, 4, 5, 1, 2 }, 1)]
        [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0)]
        [InlineData(new int[] { 11, 13, 15, 17 }, 11)]
        public void Test(int[] ints, int expected)
        {
            var actual = FindMinimumInRotatedSortedArraySolution.FindMin(ints);

            Assert.Equal(expected, actual);
        }
    }
}
