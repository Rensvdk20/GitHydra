using Domain;
using Domain.SprintState;
using Moq;

namespace GitHydra.Tests.SprintStateTests
{
    public class SprintFinishedTest
    {
        [Fact]
        public void Constructor_WithoutReviewSummary_ThrowsException()
        {
            // Arrange
            var sprintContextMock = new Mock<ISprintContext>();
            sprintContextMock.Setup(m => m.GetReviewSummary()).Returns((string)null); // Geen review samenvatting instellen

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => new SprintFinished(sprintContextMock.Object));
        }

        [Fact]
        public void Constructor_WithReviewSummary_CreatesInstance()
        {
            // Arrange
            var sprintContextMock = new Mock<ISprintContext>();
            sprintContextMock.Setup(m => m.GetReviewSummary()).Returns("Review summary"); // Review samenvatting instellen

            // Act
            var sprintFinished = new SprintFinished(sprintContextMock.Object);

            // Assert
            Assert.NotNull(sprintFinished);
        }

        [Fact]
        public void StartSprint_ThrowsException()
        {
            // Arrange
            var sprintContextMock = new Mock<ISprintContext>();
            sprintContextMock.Setup(m => m.GetReviewSummary()).Returns("Sample review summary");
            var sprintFinished = new SprintFinished(sprintContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => sprintFinished.StartSprint());
        }

        [Fact]
        public void CancelSprint_ThrowsException()
        {
            // Arrange
            var sprintContextMock = new Mock<ISprintContext>();
            sprintContextMock.Setup(m => m.GetReviewSummary()).Returns("Sample review summary"); // Mocking the GetReviewSummary method to return a non-null value
            var sprintFinished = new SprintFinished(sprintContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => sprintFinished.CancelSprint());
        }

        [Fact]
        public void FinishSprint_ThrowsException()
        {
            // Arrange
            var sprintContextMock = new Mock<ISprintContext>();
            sprintContextMock.Setup(m => m.GetReviewSummary()).Returns("Sample review summary");
            var sprintFinished = new SprintFinished(sprintContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => sprintFinished.FinishSprint());
        }

        [Fact]
        public void Change_ThrowsException()
        {
            // Arrange
            var sprintContextMock = new Mock<ISprintContext>();
            sprintContextMock.Setup(m => m.GetReviewSummary()).Returns("Sample review summary");
            var sprintFinished = new SprintFinished(sprintContextMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => sprintFinished.Change("New Name", DateTime.Now, DateTime.Now.AddDays(7)));
        }
    }
}