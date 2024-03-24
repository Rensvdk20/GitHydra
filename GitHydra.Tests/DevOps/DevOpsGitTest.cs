using Infrastructure.DevOps;
using Moq;

namespace GitHydra.Tests.DevOps
{
    public class DevOpsGitTest
    {
        [Fact]
        public void Push_MethodCalledSuccessfully()
        {
            // Arrange
            var gitMock = new Mock<DevOpsGit>();

            // Act
            gitMock.Object.Push();

            // Assert
            gitMock.Verify(g => g.Push(), Times.Once);
        }

        [Fact]
        public void Pull_MethodCalledSuccessfully()
        {
            // Arrange
            var gitMock = new Mock<DevOpsGit>();

            // Act
            gitMock.Object.Pull();

            // Assert
            gitMock.Verify(g => g.Pull(), Times.Once);
        }

        [Fact]
        public void Commit_MethodCalledSuccessfully()
        {
            // Arrange
            var gitMock = new Mock<DevOpsGit>();

            // Act
            gitMock.Object.Commit();

            // Assert
            gitMock.Verify(g => g.Commit(), Times.Once);
        }

        [Fact]
        public void Stash_MethodCalledSuccessfully()
        {
            // Arrange
            var gitMock = new Mock<DevOpsGit>();

            // Act
            gitMock.Object.Stash();

            // Assert
            gitMock.Verify(g => g.Stash(), Times.Once);
        }

        [Fact]
        public void Branch_MethodCalledSuccessfully()
        {
            // Arrange
            var gitMock = new Mock<DevOpsGit>();

            // Act
            gitMock.Object.Branch();

            // Assert
            gitMock.Verify(g => g.Branch(), Times.Once);
        }

        [Fact]
        public void Checkout_MethodCalledSuccessfully()
        {
            // Arrange
            var gitMock = new Mock<DevOpsGit>();

            // Act
            gitMock.Object.Checkout();

            // Assert
            gitMock.Verify(g => g.Checkout(), Times.Once);
        }
    }
}
