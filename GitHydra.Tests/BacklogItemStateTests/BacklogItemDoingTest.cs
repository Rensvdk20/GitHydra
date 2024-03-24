using Domain;
using Domain.BacklogItemState;
using Moq;

namespace GitHydra.Tests.BacklogItemStateTests
{
    public class BacklogItemDoingTest
    {
        public class BacklogItemDoingTests
        {
            [Fact]
            public void MoveToTodo_ShouldThrowException()
            {
                // Arrange
                var contextMock = new Mock<IBacklogItemContext>();
                var backlogItemDoing = new BacklogItemDoing(contextMock.Object);

                // Act & Assert
                Assert.Throws<InvalidOperationException>(() => backlogItemDoing.MoveToTodo());
            }

            [Fact]
            public void MoveToDoing_ShouldThrowException()
            {
                // Arrange
                var contextMock = new Mock<IBacklogItemContext>();
                var backlogItemDoing = new BacklogItemDoing(contextMock.Object);

                // Act & Assert
                Assert.Throws<InvalidOperationException>(() => backlogItemDoing.MoveToDoing());
            }

            [Fact]
            public void MoveToReadyForTesting_ShouldSetStateToReadyForTesting()
            {
                // Arrange
                var contextMock = new Mock<IBacklogItemContext>();
                var backlogItemDoing = new BacklogItemDoing(contextMock.Object);

                // Act
                backlogItemDoing.MoveToReadyForTesting();

                // Assert
                contextMock.Verify(c => c.SetState(It.IsAny<IBacklogItemState>()), Times.Once);
            }

            [Fact]
            public void MoveToTesting_ShouldThrowException()
            {
                // Arrange
                var contextMock = new Mock<IBacklogItemContext>();
                var backlogItemDoing = new BacklogItemDoing(contextMock.Object);

                // Act & Assert
                Assert.Throws<InvalidOperationException>(() => backlogItemDoing.MoveToTesting());
            }

            [Fact]
            public void MoveToTested_ShouldThrowException()
            {
                // Arrange
                var contextMock = new Mock<IBacklogItemContext>();
                var backlogItemDoing = new BacklogItemDoing(contextMock.Object);

                // Act & Assert
                Assert.Throws<InvalidOperationException>(() => backlogItemDoing.MoveToTested());
            }

            [Fact]
            public void MoveToDone_ShouldThrowException()
            {
                // Arrange
                var contextMock = new Mock<IBacklogItemContext>();
                var backlogItemDoing = new BacklogItemDoing(contextMock.Object);

                // Act & Assert
                Assert.Throws<InvalidOperationException>(() => backlogItemDoing.MoveToDone());
            }
        }
    }
}