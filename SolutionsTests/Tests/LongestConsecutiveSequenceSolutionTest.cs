using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsTests.Tests
{
    public class LongestConsecutiveSequenceSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
        [InlineData(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
        public void Test(int[] ints, int expected)
        {
            var actual = LongestConsecutiveSequenceSolution.LongestConsecutive(ints);

            Assert.Equal(expected, actual);
        }
    }
}
