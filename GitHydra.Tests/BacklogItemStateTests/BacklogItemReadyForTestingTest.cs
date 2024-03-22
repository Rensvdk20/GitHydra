using Domain;
using Domain.BacklogItemState;
using Moq;

namespace GitHydra.Tests.BacklogItemStateTests
{
    public class BacklogItemReadyForTestingTest
    {
        [Fact]
        public void MoveToTodo_SuccessfullyMovesToTodo()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var readyForTestingState = new BacklogItemReadyForTesting(backlogItemContextMock.Object);

            // Act
            readyForTestingState.MoveToTodo();

            // Assert
            backlogItemContextMock.Verify(m => m.SetState(It.IsAny<IBacklogItemState>()), Times.Once);
        }

        [Fact]
        public void MoveToDoing_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var readyForTestingState = new BacklogItemReadyForTesting(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => readyForTestingState.MoveToDoing());
        }

        [Fact]
        public void MoveToReadyForTesting_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var readyForTestingState = new BacklogItemReadyForTesting(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => readyForTestingState.MoveToReadyForTesting());
        }

        [Fact]
        public void MoveToTesting_SuccessfullyMovesToTesting()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var readyForTestingState = new BacklogItemReadyForTesting(backlogItemContextMock.Object);

            // Act
            readyForTestingState.MoveToTesting();

            // Assert
            backlogItemContextMock.Verify(m => m.SetState(It.IsAny<IBacklogItemState>()), Times.Once);
        }

        [Fact]
        public void MoveToTested_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var readyForTestingState = new BacklogItemReadyForTesting(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => readyForTestingState.MoveToTested());
        }

        [Fact]
        public void MoveToDone_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var readyForTestingState = new BacklogItemReadyForTesting(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => readyForTestingState.MoveToDone());
        }
    }
}
