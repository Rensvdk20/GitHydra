using Domain.Employees;
using Domain.Interfaces;
using Domain;
using Infrastructure.ExportBehaviour;
using Moq;

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
    }
}