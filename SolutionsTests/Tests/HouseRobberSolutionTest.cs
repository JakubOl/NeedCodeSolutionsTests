using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsTests.Tests
{
    public class HouseRobberSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1 }, 4)]
        [InlineData(new int[] { 2, 7, 9, 3, 1 }, 12)]
        public void Test(int[] ints, int expected)
        {
            var actual = HouseRobberSolution.Rob(ints);

            Assert.Equal(expected, actual);
        }
    }
}
