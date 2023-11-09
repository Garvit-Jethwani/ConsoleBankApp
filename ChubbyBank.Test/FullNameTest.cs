using Core.Implementations.Validations;

namespace ChubbyBank.Test
{
    public class FullNameTest
    {
        [Fact]

        public void ValidFullName_Test()
        {
            // AAA

            // Arrange
            var fullname = "Chubby Mmoh";

            // Act
            var actual = AuthValidations.IsValidFullName(fullname);
            var expected = true;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidFullName_Test()
        {
            var fullname = "ChubbyMmoh";
            var actual = AuthValidations.IsValidEmail(fullname);
            var expected = false;   
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(true, "Chubby Mmoh")]
        [InlineData(false, "Chubby mmoh")]
        [InlineData(false, "chubby Mmoh")]
        [InlineData(false, "ChubbyMmoh")]
        [InlineData(false, "123 Mmoh")]
        [InlineData(false, "Chubby123 Mmoh")]
        [InlineData(false, "Chubby123! mmoh!")]

        public void FullName_TestCases(bool expected, string fullname)
        {
            // Act
            var actual = AuthValidations.IsValidFullName(fullname);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

