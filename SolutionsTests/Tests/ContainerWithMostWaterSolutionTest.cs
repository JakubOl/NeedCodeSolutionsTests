namespace SolutionsTests.Tests
{
    public class ContainerWithMostWaterSolutionTest
    {
        [Theory]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [InlineData(new int[] { 1, 1 }, 1)]
        public void Test(int[] ints, int expected)
        {
            var actual = ContainerWithMostWaterSolution.MaxArea(ints);

            Assert.Equal(expected, actual); 
        }
    }
}
