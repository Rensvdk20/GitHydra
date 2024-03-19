using Domain.SprintState;
using DomainServices;
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
    }
}
