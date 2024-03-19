using Domain.SprintState;
using DomainServices;
using Moq;

namespace GitHydra.Tests.SprintStateTests
{
    public class SprintCancelledTest
    {
        [Fact]
        public void StartSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var cancelledState = new SprintCancelled(sprintContextMock.Object);

            Assert.Throws<InvalidOperationException>(() => cancelledState.StartSprint());
        }

        [Fact]
        public void CancelSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var cancelledState = new SprintCancelled(sprintContextMock.Object);

            Assert.Throws<InvalidOperationException>(() => cancelledState.CancelSprint());
        }

        [Fact]
        public void FinishSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var cancelledState = new SprintCancelled(sprintContextMock.Object);

            Assert.Throws<InvalidOperationException>(() => cancelledState.FinishSprint());
        }
    }
}
