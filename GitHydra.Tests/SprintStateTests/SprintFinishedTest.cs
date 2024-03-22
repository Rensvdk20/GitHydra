using Domain;
using Domain.SprintState;
using Moq;

namespace GitHydra.Tests.SprintStateTests
{
    public class SprintFinishedTest
    {
        [Fact]
        public void StartSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var finishedState = new SprintFinished(sprintContextMock.Object);

            Assert.Throws<InvalidOperationException>(() => finishedState.StartSprint());
        }

        [Fact]
        public void CancelSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var finishedState = new SprintFinished(sprintContextMock.Object);

            Assert.Throws<InvalidOperationException>(() => finishedState.CancelSprint());
        }

        [Fact]
        public void FinishSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var finishedState = new SprintFinished(sprintContextMock.Object);

            Assert.Throws<InvalidOperationException>(() => finishedState.FinishSprint());
        }
    }
}
