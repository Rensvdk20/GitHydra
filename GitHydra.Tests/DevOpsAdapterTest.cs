using Infrastructure.DevOps;
using Moq;

namespace GitHydra.Tests
{
    public class DevOpsAdapterTest
    {
        [Fact]
        public void GetSource_CallsPipelineSourceMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.GetSource();

            // Assert
            pipelineMock.Verify(p => p.Source(), Times.Once);
        }

        [Fact]
        public void GetPackage_CallsPipelinePackageMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.GetPackage();

            // Assert
            pipelineMock.Verify(p => p.Package(), Times.Once);
        }

        [Fact]
        public void GetTest_CallsPipelineTestMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.GetTest();

            // Assert
            pipelineMock.Verify(p => p.Test(), Times.Once);
        }

        [Fact]
        public void GetAnalysis_CallsPipelineAnalyseMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.GetAnalysis();

            // Assert
            pipelineMock.Verify(p => p.Analyse(), Times.Once);
        }

        [Fact]
        public void GetDeployment_CallsPipelineDeploymentMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.GetDeployment();

            // Assert
            pipelineMock.Verify(p => p.Deployment(), Times.Once);
        }

        [Fact]
        public void GetUtility_CallsPipelineUtilityMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.GetUtility();

            // Assert
            pipelineMock.Verify(p => p.Utility(), Times.Once);
        }

        [Fact]
        public void Push_CallsGitPushMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.Push();

            // Assert
            gitMock.Verify(g => g.Push(), Times.Once);
        }

        [Fact]
        public void Pull_CallsGitPullMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.Pull();

            // Assert
            gitMock.Verify(g => g.Pull(), Times.Once);
        }

        [Fact]
        public void Commit_CallsGitCommitMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.Commit();

            // Assert
            gitMock.Verify(g => g.Commit(), Times.Once);
        }

        [Fact]
        public void Stash_CallsGitStashMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.Stash();

            // Assert
            gitMock.Verify(g => g.Stash(), Times.Once);
        }

        [Fact]
        public void Pop_CallsGitPopMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.Branch();

            // Assert
            gitMock.Verify(g => g.Branch(), Times.Once);
        }

        [Fact]
        public void Checkout_CallsGitCheckoutMethod()
        {
            // Arrange
            var pipelineMock = new Mock<DevOpsPipeline>();
            var gitMock = new Mock<DevOpsGit>();
            var adapter = new DevOpsAdapter(pipelineMock.Object, gitMock.Object);

            // Act
            adapter.Checkout();

            // Assert
            gitMock.Verify(g => g.Checkout(), Times.Once);
        }
    }
}
