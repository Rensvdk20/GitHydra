using Domain;
using Domain.Employees;
using Moq;

namespace GitHydra.Tests
{
    public class ThreadTest
    {
        [Fact]
        public void CloseThread_ThreadClosedSuccessfully()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task", new Developer("John", "john@example.com"));
            var thread = new Domain.Thread("Discussion thread", backlogItem);

            // Act
            thread.CloseThread();

            // Assert
            Assert.False(thread.GetStatus());
        }

        [Fact]
        public void AddMessage_MessageAddedSuccessfullyWhenThreadChangeable()
        {
            // Arrange
            var backlogItem = new BacklogItem("Task", new Developer("John", "john@example.com"));
            var thread = new Domain.Thread("Discussion thread", backlogItem);
            var messageMock = new Mock<IMessage>();

            // Act
            thread.AddMessage(messageMock.Object);

            // Assert
            Assert.Contains(messageMock.Object, thread.GetAllMessages());
        }
    }
}
