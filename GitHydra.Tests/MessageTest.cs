using Domain;
using Moq;

namespace GitHydra.Tests
{
    public class MessageTest
    {
        [Fact]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            var mockEmployee = new Mock<IEmployee>();
            var mockThread = new Mock<IThread>();
            var content = "Test message";

            // Act
            var message = new Message(mockEmployee.Object, content, mockThread.Object);

            // Assert
            Assert.Equal(mockEmployee.Object, message.GetAuthor()); // Indirect getter test
            Assert.Equal(content, message.GetContent());
            Assert.Equal(mockThread.Object, message.GetThread()); // Indirect getter test
            Assert.IsType<List<IMessage>>(message.GetAllMessages());
            Assert.Empty(message.GetAllMessages()); // Test initial state of messages list
        }

        [Fact]
        public void AddMessage_ThreadChangeable_AddsMessageAndCallsNotification()
        {
            // Arrange
            var mockEmployee = new Mock<IEmployee>();
            var mockThread = new Mock<IThread>();
            var mockMessage = new Mock<IMessage>();
            var content = "Test message";
            mockThread.Setup(t => t.IsChangeable()).Returns(true);

            // Act
            var message = new Message(mockEmployee.Object, content, mockThread.Object);
            message.AddMessage(mockMessage.Object);

            // Assert
            Assert.Contains(mockMessage.Object, message.GetAllMessages());
            mockThread.Verify(t => t.NotifyTeamMembersOfNewMessage(), Times.Once);
        }

        [Fact]
        public void AddMessage_ThreadNotChangeable_DoesNotAddMessageOrCallNotification()
        {
            // Arrange
            var mockEmployee = new Mock<IEmployee>();
            var mockThread = new Mock<IThread>();
            var mockMessage = new Mock<IMessage>();
            var content = "Test message";
            mockThread.Setup(t => t.IsChangeable()).Returns(false);

            // Act
            var message = new Message(mockEmployee.Object, content, mockThread.Object);
            message.AddMessage(mockMessage.Object);

            // Assert
            Assert.DoesNotContain(mockMessage.Object, message.GetAllMessages());
            mockThread.Verify(t => t.NotifyTeamMembersOfNewMessage(), Times.Never);
        }

        [Fact]
        public void GetAllMessages_ReturnsCopyOfMessagesList()
        {
            // Arrange
            var mockEmployee = new Mock<IEmployee>();
            var mockThread = new Mock<IThread>();
            var content = "Test message";
            var message = new Message(mockEmployee.Object, content, mockThread.Object);

            var message1 = new Mock<IMessage>();
            var message2 = new Mock<IMessage>();

            mockThread.Setup(t => t.IsChangeable()).Returns(true);  // Mock IsChangeable

            message.AddMessage(message1.Object);
            message.AddMessage(message2.Object);

            // Act
            var allMessages = message.GetAllMessages();

            // Assert
            Assert.Equal(2, allMessages.Count);
            Assert.Contains(message1.Object, allMessages);
            Assert.Contains(message2.Object, allMessages);
        }
    }
}