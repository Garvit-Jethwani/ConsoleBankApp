using Core.Implementations.Validations;

namespace ChubbyBank.Test
{
    public class EmailTest
    {
        [Theory]
        [InlineData(true, "mmoh@gmail.com")]
        [InlineData(true, "Mmoh@gmail.com")]
        [InlineData(true, "mmoh32@gmail.com")]
        [InlineData(false, "mmoh!@gmail.com")]
        [InlineData(false, "mmohgmail.com")]
        [InlineData(false, "mmoh @gmail.com")]

        public void InValidEmail_TestCases(bool expected, string email)
        {
            var actual = AuthValidations.IsValidEmail(email);
            Assert.Equal(expected, actual);
        }
    }
}
