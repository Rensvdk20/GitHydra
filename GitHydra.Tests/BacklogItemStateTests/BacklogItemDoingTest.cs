using Domain;
using Domain.BacklogItemState;
using Moq;

namespace GitHydra.Tests.BacklogItemStateTests
{
    public class BacklogItemDoingTest
    {
        [Fact]
        public void MoveToTodo_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doingState = new BacklogItemDoing(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doingState.MoveToTodo());
        }

        [Fact]
        public void MoveToDoing_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doingState = new BacklogItemDoing(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doingState.MoveToDoing());
        }

        [Fact]
        public void MoveToReadyForTesting_SuccessfullyMovesToReadyForTesting()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doingState = new BacklogItemDoing(backlogItemContextMock.Object);

            // Act
            doingState.MoveToReadyForTesting();

            // Assert
            backlogItemContextMock.Verify(m => m.SetState(It.IsAny<IBacklogItemState>()), Times.Once);
        }

        [Fact]
        public void MoveToTesting_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doingState = new BacklogItemDoing(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doingState.MoveToTesting());
        }

        [Fact]
        public void MoveToTested_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doingState = new BacklogItemDoing(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doingState.MoveToTested());
        }

        [Fact]
        public void MoveToDone_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doingState = new BacklogItemDoing(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doingState.MoveToDone());
        }
    }
}
