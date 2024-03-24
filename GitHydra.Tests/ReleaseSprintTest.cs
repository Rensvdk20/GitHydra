using Domain.Employees;
using Domain.Interfaces;
using Domain;
using Infrastructure.ExportBehaviour;
using Moq;
using Infrastructure.DevOps;

namespace GitHydra.Tests
{
    public class ReleaseSprintTests
    {
        [Fact]
        public void SetName_SetsNameSuccessfully()
        {
            // Arrange
            var sprint = new ReleaseSprint("Sprint 1", new DateTime(2024, 3, 1), new DateTime(2024, 3, 15), new ScrumMaster("Jan", "Jan@mail.com"), new ExportPDF(), new Mock<IDevOpsPipelineService>().Object);
            var newName = "New Sprint Name";

            // Act
            sprint.SetName(newName);

            // Assert
            Assert.Equal(newName, sprint.ToString());
        }

        [Fact]
        public void SetStartDate_SetsStartDateSuccessfully()
        {
            // Arrange
            var sprint = new ReleaseSprint("Sprint 1", new DateTime(2024, 3, 1), new DateTime(2024, 3, 15), new ScrumMaster("Jan", "Jan@mail.com"), new ExportPDF(), new Mock<IDevOpsPipelineService>().Object);
            var newStartDate = new DateTime(2024, 3, 5);

            // Act
            sprint.SetStartDate(newStartDate);

            // Assert
            Assert.Equal(newStartDate, sprint.GetStartDate());
        }

        [Fact]
        public void SetEndDate_SetsEndDateSuccessfully()
        {
            // Arrange
            var sprint = new ReleaseSprint("Sprint 1", new DateTime(2024, 3, 1), new DateTime(2024, 3, 15), new ScrumMaster("Jan", "Jan@mail.com"), new ExportPDF(), new Mock<IDevOpsPipelineService>().Object);
            var newEndDate = new DateTime(2024, 3, 20);

            // Act
            sprint.SetEndDate(newEndDate);

            // Assert
            Assert.Equal(newEndDate, sprint.GetEndDate());
        }

        [Fact]
        public void GetProject_ThrowsExceptionWhenNotAttachedToProject()
        {
            // Arrange
            var sprint = new ReleaseSprint("Sprint 1", new DateTime(2024, 3, 1), new DateTime(2024, 3, 15), new ScrumMaster("Jan", "Jan@mail.com"), new ExportPDF(), new Mock<IDevOpsPipelineService>().Object);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => sprint.GetProject());
        }

        [Fact]
        public void RunPipeline_ThrowsExceptionWhenNoPipelineService()
        {
            // Arrange
            var sprint = new ReleaseSprint("Sprint 1", new DateTime(2024, 3, 1), new DateTime(2024, 3, 15), new ScrumMaster("Jan", "Jan@mail.com"), new ExportPDF(), null);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => sprint.RunPipeline());
        }

        [Fact]
        public void GetReviewSummary_ReturnsReviewSummary()
        {
            // Arrange
            var sprint = new ReleaseSprint("Sprint 1", new DateTime(2024, 3, 1), new DateTime(2024, 3, 15), new ScrumMaster("Jan", "Jan@mail.com"), new ExportPDF(), new Mock<IDevOpsPipelineService>().Object);
            var reviewSummary = "Test review summary";
            sprint.SetReviewSummary(reviewSummary);

            // Act
            var result = sprint.GetReviewSummary();

            // Assert
            Assert.Equal(reviewSummary, result);
        }

        [Fact]
        public void GetSprintBacklog_ReturnsSprintBacklog()
        {
            // Arrange
            var sprint = new ReleaseSprint("Sprint 1", new DateTime(2024, 3, 1), new DateTime(2024, 3, 15), new ScrumMaster("Jan", "Jan@mail.com"), new ExportPDF(), new Mock<IDevOpsPipelineService>().Object);

            // Act
            var result = sprint.GetSprintBacklog();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void SetProject_SetsProjectCorrectly()
        {
            // Arrange
            var sprint = new ReleaseSprint("Sprint 1", new DateTime(2024, 3, 1), new DateTime(2024, 3, 15), new ScrumMaster("Jan", "Jan@mail.com"), new ExportPDF(), new Mock<IDevOpsPipelineService>().Object);
            var project = new Project("Project 1", new ProductOwner("Owner", "owner@example.com"), new DevOpsGitService(new DevOpsAdapter(new DevOpsPipeline(), new DevOpsGit())));

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
            var sprint = new ReleaseSprint("Sprint 1", new DateTime(2024, 3, 1), new DateTime(2024, 3, 15), new ScrumMaster("Jan", "Jan@mail.com"), new ExportPDF(), pipelineServiceMock.Object);

            // Act
            var result = sprint.GetDevOpsPipelineService();

            // Assert
            Assert.Equal(pipelineServiceMock.Object, result);
        }
    }
}