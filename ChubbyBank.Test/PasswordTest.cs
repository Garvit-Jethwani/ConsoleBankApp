using Core.Implementations.Validations;

namespace ChubbyBank.Test
{
    public class PasswordTest
    {
        [Theory]
        [InlineData(false, "mmohsky4310")]
        [InlineData(false, "mmoh@4310")]
        [InlineData(false, "mmoh@gmail.com")]
        [InlineData(false, "mmoh")]
        [InlineData(true, "Mmoh43!#")]

        public void InValidPassword_TestCases(bool expected, string password)
        {
            var actual = AuthValidations.IsValidPassword(password);
            Assert.Equal(expected, actual);
        }
    }
}
