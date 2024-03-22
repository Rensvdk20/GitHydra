using Domain;
using Domain.BacklogItemState;
using Moq;

namespace GitHydra.Tests.BacklogItemStateTests
{
    public class BacklogItemTestingTest
    {
        [Fact]
        public void MoveToTodo_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testingState = new BacklogItemTesting(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => testingState.MoveToTodo());
        }

        [Fact]
        public void MoveToDoing_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testingState = new BacklogItemTesting(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => testingState.MoveToDoing());
        }

        [Fact]
        public void MoveToReadyForTesting_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testingState = new BacklogItemTesting(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => testingState.MoveToReadyForTesting());
        }

        [Fact]
        public void MoveToTesting_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testingState = new BacklogItemTesting(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => testingState.MoveToTesting());
        }

        [Fact]
        public void MoveToTested_SuccessfullyMovesToTested()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testingState = new BacklogItemTesting(backlogItemContextMock.Object);

            // Act
            testingState.MoveToTested();

            // Assert
            backlogItemContextMock.Verify(m => m.SetState(It.IsAny<IBacklogItemState>()), Times.Once);
        }

        [Fact]
        public void MoveToDone_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testingState = new BacklogItemTesting(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => testingState.MoveToDone());
        }
    }
}
