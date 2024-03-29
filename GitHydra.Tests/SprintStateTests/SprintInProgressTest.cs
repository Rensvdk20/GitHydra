﻿using Domain;
using Domain.SprintState;
using Moq;

namespace GitHydra.Tests.SprintStateTests
{
    public class SprintInProgressTest
    {
        [Fact]
        public void StartSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var inProgressState = new SprintInProgress(sprintContextMock.Object);

            Assert.Throws<InvalidOperationException>(() => inProgressState.StartSprint());
        }

        [Fact]
        public void CancelSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            var inProgressState = new SprintInProgress(sprintContextMock.Object);

            inProgressState.CancelSprint();

            sprintContextMock.Verify(x => x.SetSprintState(It.IsAny<SprintCancelled>()));
        }

        [Fact]
        public void FinishSprint()
        {
            var sprintContextMock = new Mock<ISprintContext>();
            sprintContextMock.Setup(m => m.GetReviewSummary()).Returns("Sample review summary");
            var inProgressState = new SprintInProgress(sprintContextMock.Object);

            inProgressState.FinishSprint();

            sprintContextMock.Verify(x => x.SetSprintState(It.IsAny<SprintFinished>()));
        }

        [Fact]
        public void Change_ThrowsException()
        {
            // Arrange
            var sprintContextMock = new Mock<ISprintContext>();
            var inProgressState = new SprintInProgress(sprintContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => inProgressState.Change("New Name", DateTime.Now, DateTime.Now.AddDays(7)));
        }
    }
}
