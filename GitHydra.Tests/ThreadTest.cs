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
            var backlogItem = new BacklogItem("Item", new Developer("John", "john@example.com"));
            var thread = new Domain.Thread("Discussion thread", backlogItem);
            var author = new Developer("John", "john@example.com");
            var message = new Message(author, "Hello, world!", thread);

            // Act
            thread.AddMessage(message);

            // Assert
            Assert.Contains(message, thread.GetAllMessages());
        }

        [Fact]
        public void CloseThread_ThreadClosedSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem("Item", new Developer("John", "john@example.com"));
            var thread = new Domain.Thread("Discussion thread", backlogItem);

            // Act
            thread.CloseThread();

            // Assert
            Assert.False(thread.GetStatus());
        }
    }
}
