namespace Test_Software_Engineer
{
    public class IntToAlienTest
    {
        [Theory]
        [InlineData(3, "AAA")]
        [InlineData(58, "LBAAA")]
        [InlineData(1994, "RCRZCAB")]
        public void IntToAlien_ShouldReturnCorrectResult(int input, string expected)
        {
            // Arrange
            var problem = new IntToAlien();

            // Act
            var result = problem.ConvertIntToAlien(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}