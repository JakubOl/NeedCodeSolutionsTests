using NeetCodeSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsTests.Tests
{
    public class BestTimeToBuyAndSellStockSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void Test(int[] ints, int expected)
        {
            var actual = BestTimeToBuyAndSellStockSolution.MaxProfit(ints);

            Assert.Equal(expected, actual);
        }
    }
}
