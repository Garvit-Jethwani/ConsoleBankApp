using Core.Implementations;
using Data.Entities;

namespace ChubbyBank.Test
{
    public class ReadCustomerFromJsonFile
    {
        [Fact]
        public void ReadCustomersFromJsonFile_ShouldDeserializeAndReturnCustomers()
        {
            // Arrange
            string filePath = "test.json"; // Provide a test file path
            File.WriteAllText(filePath, "{'FullName': 'Mmoh Jnr'}");

            // Act
            List<User> customers = Help.ReadCustomersFromJsonFile(filePath);

            // Assert
            Assert.NotNull(customers);
            Assert.Single(customers);

            // Optionally, you can validate specific customer properties
            Assert.Equal("Chubby Jnr", customers[0].FullName);


            // Cleanup: Delete the test file
            File.Delete(filePath);
        }
    }
}
