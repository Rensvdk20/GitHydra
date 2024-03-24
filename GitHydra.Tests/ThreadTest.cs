using Domain;
using Domain.Employees;
using Moq;

namespace GitHydra.Tests
{
    public class ThreadTest
    {
        //[Fact]
        //public void AddMessage_MessageAddedSuccessfully()
        //{
        //    // Arrange
        //    var backlogItem = new BacklogItem("Task", new Developer("John", "john@example.com"));
        //    var author = new Developer("John", "john@example.com");

        //    // Mock de Thread
        //    var threadMock = new Mock<Domain.Thread>("Discussion thread", backlogItem);
        //    threadMock.Setup(m => m.IsChangeable).Returns(true);

        //    var message = new Message(author, "Hello, world!", threadMock.Object);

        //    // Act
        //    threadMock.Object.AddMessage(message);

        //    // Assert
        //    Assert.Contains(message, threadMock.Object.GetAllMessages());
        //}

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
    }
}
