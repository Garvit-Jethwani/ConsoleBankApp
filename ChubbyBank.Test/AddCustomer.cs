using Core.Implementations;
using Data.Entities;

namespace ChubbyBank.Test
{
    public class AddCustomer
    {
        [Fact]
        public void SendCustomerDataToJsonFile_ShouldCreateFileAndAppendData()
        {
            // Arrange
            string filePath = "test.json"; // Provide a test file path
            User user = new()
            {

                FullName = "Chubby Jnr"

            };

            // Act
             Help.SendCustomerDataToJsonFile(user, filePath);

            // Assert
            // Check if the file exists after running the method
            Assert.True(File.Exists(filePath));

            // Optionally, you can read the file and validate its content
            string fileContent = File.ReadAllText(filePath);
            Assert.Contains("Chubby Jnr", fileContent); // Replace with your expected data
        }
    }
}
