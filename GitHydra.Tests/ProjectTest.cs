using Domain.Employees;
using Domain.Interfaces;
using Domain;
using Moq;

namespace GitHydra.Tests
{
    public class ProjectTest
    {
        [Fact]
        public void AddSprint_SprintAddedSuccessfully()
        {
            // Arrange
            var project = new Project("Project 1", new ProductOwner("Jan", "Jan@mail.com"), new Mock<IDevOpsGitService>().Object);
            var sprint = new Mock<ISprint>().Object;

            // Act
            project.AddSprint(sprint);

            // Assert
            Assert.Contains(sprint, project.GetSprints());
        }

        [Fact]
        public void AddTester_TesterAddedSuccessfully()
        {
            // Arrange
            var project = new Project("Project 1", new ProductOwner("Jan", "Jan@mail.com"), new Mock<IDevOpsGitService>().Object);
            var tester = new Tester("Tester 1", "tester@example.com");

            // Act
            project.AddTester(tester);

            // Assert
            Assert.Contains(tester, project.GetTesters());
        }

        [Fact]
        public void GetProductOwner_ReturnsProductOwnerSuccessfully()
        {
            // Arrange
            var productOwner = new ProductOwner("Jan", "Jan@mail.com");
            var project = new Project("Project 1", productOwner, new Mock<IDevOpsGitService>().Object);

            // Act
            var result = project.GetProductOwner();

            // Assert
            Assert.Equal(productOwner, result);
        }

        [Fact]
        public void GetDevOpsGitService_ReturnsDevOpsGitServiceSuccessfully()
        {
            // Arrange
            var devOpsGitServiceMock = new Mock<IDevOpsGitService>();
            var project = new Project("Project 1", new ProductOwner("Jan", "Jan@mail.com"), devOpsGitServiceMock.Object);

            // Act
            var result = project.GetDevOpsGitService();

            // Assert
            Assert.Equal(devOpsGitServiceMock.Object, result);
        }
    }
}
