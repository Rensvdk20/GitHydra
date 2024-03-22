using Domain;
using Domain.BacklogItemState;
using Moq;

namespace GitHydra.Tests.BacklogItemStateTests
{
    public class BacklogItemDoneTest
    {
        [Fact]
        public void MoveToTodo_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doneState = new BacklogItemDone(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doneState.MoveToTodo());
        }

        [Fact]
        public void MoveToDoing_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doneState = new BacklogItemDone(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doneState.MoveToDoing());
        }

        [Fact]
        public void MoveToReadyForTesting_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doneState = new BacklogItemDone(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doneState.MoveToReadyForTesting());
        }

        [Fact]
        public void MoveToTesting_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doneState = new BacklogItemDone(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doneState.MoveToTesting());
        }

        [Fact]
        public void MoveToTested_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doneState = new BacklogItemDone(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doneState.MoveToTested());
        }

        [Fact]
        public void MoveToDone_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var doneState = new BacklogItemDone(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => doneState.MoveToDone());
        }
    }
}
