using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsTests.Tests
{
    public class JumpGameSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 1, 4 }, true)]
        [InlineData(new int[] { 3, 2, 1, 0, 4 }, false)]
        public void Test(int[] ints, bool expected)
        {
            var actual = JumpGameSolution.CanJump(ints);

            Assert.Equal(expected, actual);
        }
    }
}
