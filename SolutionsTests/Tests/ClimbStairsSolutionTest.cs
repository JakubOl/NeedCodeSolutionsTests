namespace SolutionsTests.Tests
{
    public class ClimbStairsSolutionTest
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 5)]
        public void Test(int steps, int expected)
        {
            var actual = ClimbStairsSolution.ClimbStairs(steps);

            Assert.Equal(expected, actual);
        }
    }
}
