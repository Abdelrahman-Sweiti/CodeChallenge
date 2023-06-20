using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using CodeCC;

namespace CodeChallenge01.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ReverseArray_WithEmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] array = new int[] { };

            // Act
            int[] result = CodeCC.Program.ReverseArray(array);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void ReverseArray_WithArray_ReturnsReversedArray()
        {
            // Arrange
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int[] expected = new int[] { 5, 4, 3, 2, 1 };

            // Act
            int[] result = CodeCC.Program.ReverseArray(array);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}

