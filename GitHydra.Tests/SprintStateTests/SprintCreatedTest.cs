using Domain;
using Domain.SprintState;
using Moq;

namespace GitHydra.Tests.SprintStateTests
{
    public class SprintCreatedTest
    {
        [Fact]
        public void StartSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var createState = new SprintCreated(sprintContextMock.Object);

            createState.StartSprint();

            sprintContextMock.Verify(x => x.SetSprintState(It.IsAny<SprintInProgress>()));
        }

        [Fact]
        public void CancelSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var createState = new SprintCreated(sprintContextMock.Object);

            createState.CancelSprint();

            sprintContextMock.Verify(x => x.SetSprintState(It.IsAny<SprintCancelled>()));
        }

        [Fact]
        public void FinishSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var createState = new SprintCreated(sprintContextMock.Object);

            Assert.Throws<InvalidOperationException>(() => createState.FinishSprint());
        }

        [Fact]
        public void Change_CallsCorrectMethods()
        {
            // Arrange
            var sprintContextMock = new Mock<ISprintContext>();
            var createState = new SprintCreated(sprintContextMock.Object);

            // Act
            createState.Change("New Name", DateTime.Now, DateTime.Now.AddDays(7));

            // Assert
            sprintContextMock.Verify(x => x.SetName("New Name"), Times.Once);
            sprintContextMock.Verify(x => x.SetStartDate(It.IsAny<DateTime>()), Times.Once);
            sprintContextMock.Verify(x => x.SetEndDate(It.IsAny<DateTime>()), Times.Once);
        }
    }
}
