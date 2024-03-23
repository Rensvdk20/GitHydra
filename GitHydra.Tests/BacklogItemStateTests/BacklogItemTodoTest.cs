using Domain;
using Domain.BacklogItemState;
using Moq;

namespace GitHydra.Tests.BacklogItemStateTests
{
    public class BacklogItemTodoTest
    {
        [Fact]
        public void MoveToTodo_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var todoState = new BacklogItemTodo(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => todoState.MoveToTodo());
        }

        [Fact]
        public void MoveToDoing_SuccessfullyMovesToDoing()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var todoState = new BacklogItemTodo(backlogItemContextMock.Object);

            // Act
            todoState.MoveToDoing();

            // Assert
            backlogItemContextMock.Verify(m => m.SetState(It.IsAny<IBacklogItemState>()), Times.Once);
        }

        [Fact]
        public void MoveToReadyForTesting_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var todoState = new BacklogItemTodo(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => todoState.MoveToReadyForTesting());
        }

        [Fact]
        public void MoveToTesting_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var todoState = new BacklogItemTodo(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => todoState.MoveToTesting());
        }

        [Fact]
        public void MoveToTested_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var todoState = new BacklogItemTodo(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => todoState.MoveToTested());
        }

        [Fact]
        public void MoveToDone_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var todoState = new BacklogItemTodo(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => todoState.MoveToDone());
        }
    }
}
