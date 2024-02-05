// ********RoostGPT********
// Test generated by RoostGPT for test csharp-test using AI Type Open AI and AI Model gpt-4



// ********RoostGPT********
using System;
using NUnit.Framework;
using Moq;
using System.IO;
using Core.Services;

namespace Core.Test
{
    [TestFixture]
    public class WriteLine_4253fa5afd
    {
        private Mock<IRepository> _rep;
        private YourClassName _yourClassName; // TODO: Replace YourClassName with the actual class name that contains Run method

        [SetUp]
        public void SetUp()
        {
            _rep = new Mock<IRepository>();
            _yourClassName = new YourClassName(_rep.Object); // TODO: Replace YourClassName with the actual class name that contains Run method
        }

        [Test]
        public void Run_WhenChoiceIs1_CallsSignUp()
        {
            var input = new StringReader("1\n");
            Console.SetIn(input);

            _yourClassName.Run();

            _rep.Verify(r => r.SignUp(), Times.Once);
        }

        [Test]
        public void Run_WhenChoiceIs2_CallsLogin()
        {
            var input = new StringReader("2\n");
            Console.SetIn(input);

            _yourClassName.Run();

            _rep.Verify(r => r.Login(), Times.Once);
        }

        [Test]
        public void Run_WhenChoiceIsNot1Or2Or3_DisplaysInvalidMessage()
        {
            var input = new StringReader("4\n");
            var output = new StringWriter();
            Console.SetIn(input);
            Console.SetOut(output);

            _yourClassName.Run();

            Assert.IsTrue(output.ToString().Contains("You have entered an invalid Message"));
        }

        [Test]
        public void Run_WhenChoiceIsNot1Or2Or3_CallsRunAgain()
        {
            var input = new StringReader("4\n1\n");
            Console.SetIn(input);
            
            _yourClassName.Run();

            _rep.Verify(r => r.SignUp(), Times.Once);
        }
    }
}
