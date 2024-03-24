using Domain.Employees;
using Domain.Interfaces;
using Domain;
using Moq;

namespace GitHydra.Tests
{
    public class ProductSprintTest
    {
        [Fact]
        public void ToString_ReturnsName()
        {
            // Arrange
            var name = "Sprint 1";
            var startDate = new DateTime(2024, 3, 1);
            var endDate = new DateTime(2024, 3, 15);
            var scrumMaster = new ScrumMaster("John", "john@example.com");
            var exportStrategyMock = new Mock<IExportStrategy>();

            var sprint = new ProductSprint(name, startDate, endDate, scrumMaster, exportStrategyMock.Object);

            // Act
            var result = sprint.ToString();

            // Assert
            Assert.Equal(name, result);
        }

        [Fact]
        public void GetReviewSummary_ReturnsNullByDefault()
        {
            // Arrange
            var name = "Sprint 1";
            var startDate = new DateTime(2024, 3, 1);
            var endDate = new DateTime(2024, 3, 15);
            var scrumMaster = new ScrumMaster("John", "john@example.com");
            var exportStrategyMock = new Mock<IExportStrategy>();

            var sprint = new ProductSprint(name, startDate, endDate, scrumMaster, exportStrategyMock.Object);

            // Act
            var result = sprint.GetReviewSummary();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void SetReviewSummary_ReviewSummarySetSuccessfully()
        {
            // Arrange
            var name = "Sprint 1";
            var startDate = new DateTime(2024, 3, 1);
            var endDate = new DateTime(2024, 3, 15);
            var scrumMaster = new ScrumMaster("John", "john@example.com");
            var exportStrategyMock = new Mock<IExportStrategy>();

            var sprint = new ProductSprint(name, startDate, endDate, scrumMaster, exportStrategyMock.Object);
            var review = "This is a review summary.";

            // Act
            sprint.SetReviewSummary(review);
            var result = sprint.GetReviewSummary();

            // Assert
            Assert.Equal(review, result);
        }

        [Fact]
        public void RunPipeline_ThrowsExceptionWhenPipelineIsNull()
        {
            // Arrange
            var name = "Sprint 1";
            var startDate = new DateTime(2024, 3, 1);
            var endDate = new DateTime(2024, 3, 15);
            var scrumMaster = new ScrumMaster("John", "john@example.com");
            var exportStrategyMock = new Mock<IExportStrategy>();

            var sprint = new ProductSprint(name, startDate, endDate, scrumMaster, exportStrategyMock.Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => sprint.RunPipeline());
        }
    }
}
