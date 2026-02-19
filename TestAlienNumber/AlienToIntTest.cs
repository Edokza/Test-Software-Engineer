using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Software_Engineer.Tests
{
    public class AlienToIntTest
    {
        [Theory]
        [InlineData("AAA", 3)]
        [InlineData("LBAAA",58)]
        [InlineData("RCRZCAB", 1994)]
        public void IntToAlien_ShouldReturnCorrectResult(string input, int expected)
        {
            // Arrange
            var problem = new AlienToInt();

            // Act
            var result = problem.Converting(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
