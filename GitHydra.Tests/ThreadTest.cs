using Domain;
using Domain.Employees;

namespace GitHydra.Tests
{
    public class ThreadTest
    {
        [Fact]
        public void AddMessage_MessageAddedSuccessfully()
        {
            // Arrange
            var thread = new Domain.Thread("Discussion thread");
            var author = new Developer("John", "john@example.com");
            var message = new Message(author, "Hello, world!");

            // Act
            thread.AddMessage(message);

            // Assert
            Assert.Contains(message, thread.GetAllMessages());
        }

        [Fact]
        public void CloseThread_ThreadClosedSuccessfully()
        {
            // Arrange
            var thread = new Domain.Thread("Discussion thread");

            // Act
            thread.CloseThread();

            // Assert
            Assert.False(thread.GetStatus());
        }
    }
}
