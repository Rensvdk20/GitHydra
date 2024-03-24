using Domain;
using Domain.BacklogItemState;
using Moq;

namespace GitHydra.Tests.BacklogItemStateTests
{
    public class BacklogItemTestedTest
    {
        [Fact]
        public void MoveToTodo_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testedState = new BacklogItemTested(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => testedState.MoveToTodo());
        }

        [Fact]
        public void MoveToDoing_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testedState = new BacklogItemTested(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => testedState.MoveToDoing());
        }

        [Fact]
        public void MoveToReadyForTesting_SuccessfullyMovesToReadyForTesting()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testedState = new BacklogItemTested(backlogItemContextMock.Object);

            // Act
            testedState.MoveToReadyForTesting();

            // Assert
            backlogItemContextMock.Verify(m => m.SetState(It.IsAny<IBacklogItemState>()), Times.Once);
        }

        [Fact]
        public void MoveToTesting_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testedState = new BacklogItemTested(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => testedState.MoveToTesting());
        }

        [Fact]
        public void MoveToTested_ThrowsException()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            var testedState = new BacklogItemTested(backlogItemContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => testedState.MoveToTested());
        }

        [Fact]
        public void MoveToDone_SuccessfullyMovesToDone()
        {
            // Arrange
            var backlogItemContextMock = new Mock<IBacklogItemContext>();
            backlogItemContextMock.Setup(m => m.GetActivities()).Returns(new List<Activity>());
            var testedState = new BacklogItemTested(backlogItemContextMock.Object);

            // Act
            testedState.MoveToDone();

            // Assert
            backlogItemContextMock.Verify(m => m.SetState(It.IsAny<IBacklogItemState>()), Times.Once);
        }
    }
}
