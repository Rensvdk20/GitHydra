using Domain.Employees;
using Domain.Interfaces;
using Domain;
using Moq;
using Domain.Observer;

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

        [Fact]
        public void Export_CallsExportStrategyExportMethod()
        {
            // Arrange
            var name = "Sprint 1";
            var startDate = new DateTime(2024, 3, 1);
            var endDate = new DateTime(2024, 3, 15);
            var scrumMaster = new ScrumMaster("John", "john@example.com");
            var exportStrategyMock = new Mock<IExportStrategy>();
            var sprint = new ProductSprint(name, startDate, endDate, scrumMaster, exportStrategyMock.Object);

            // Act
            sprint.Export();

            // Assert
            exportStrategyMock.Verify(strategy => strategy.Export(sprint), Times.Once);
        }

        [Fact]
        public void Change_SetsNameAndDatesCorrectly()
        {
            // Arrange
            var name = "Sprint 1";
            var startDate = new DateTime(2024, 3, 1);
            var endDate = new DateTime(2024, 3, 15);
            var scrumMaster = new ScrumMaster("John", "john@example.com");
            var exportStrategyMock = new Mock<IExportStrategy>();
            var sprint = new ProductSprint(name, startDate, endDate, scrumMaster, exportStrategyMock.Object);

            var newName = "New Sprint Name";
            var newStartDate = new DateTime(2024, 4, 1);
            var newEndDate = new DateTime(2024, 4, 15);

            // Act
            sprint.Change(newName, newStartDate, newEndDate);

            // Assert
            Assert.Equal(newName, sprint.ToString());
            Assert.Equal(newStartDate, sprint.GetStartDate());
            Assert.Equal(newEndDate, sprint.GetEndDate());
        }

        [Fact]
        public void GetScrumMaster_ReturnsScrumMaster()
        {
            // Arrange
            var name = "Sprint 1";
            var startDate = new DateTime(2024, 3, 1);
            var endDate = new DateTime(2024, 3, 15);
            var scrumMaster = new ScrumMaster("John", "john@example.com");
            var exportStrategyMock = new Mock<IExportStrategy>();
            var sprint = new ProductSprint(name, startDate, endDate, scrumMaster, exportStrategyMock.Object);

            // Act
            var result = sprint.GetScrumMaster();

            // Assert
            Assert.Equal(scrumMaster, result);
        }

        [Fact]
        public void SetProject_SetsProjectSuccessfully()
        {
            // Arrange
            var sprint = new ProductSprint("Sprint 1", DateTime.Now, DateTime.Now.AddDays(14), new ScrumMaster("John", "john@example.com"), new Mock<IExportStrategy>().Object);
            var project = new Project("Project 1", new ProductOwner("John", "john@example.com"), new Mock<IDevOpsGitService>().Object);

            // Act
            sprint.SetProject(project);

            // Assert
            Assert.Equal(project, sprint.GetProject());
        }

        [Fact]
        public void GetDevOpsPipelineService_ReturnsPipelineService()
        {
            // Arrange
            var pipelineServiceMock = new Mock<IDevOpsPipelineService>();
            var sprint = new ProductSprint("Sprint 1", DateTime.Now, DateTime.Now.AddDays(14), new ScrumMaster("John", "john@example.com"), new Mock<IExportStrategy>().Object);

            // Act
            var result = sprint.GetDevOpsPipelineService();

            // Assert
            Assert.Equal(pipelineServiceMock.Object, pipelineServiceMock.Object);
        }
    }
}
