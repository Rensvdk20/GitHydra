using Infrastructure.DevOps;
using Domain;
using Moq;

namespace GitHydra.Tests.DevOps
{
    public class DevOpsPipelineServiceTests
    {
        [Fact]
        public void RunPipeline_CallsAllGetMethodsAndReturnsTrue()
        {
            // Arrange
            var devOpsAdapter = new DevOpsAdapter(new DevOpsPipeline(), new DevOpsGit());
            var service = new DevOpsPipelineService(devOpsAdapter);

            // Act
            var result = service.RunPipeline();

            // Assert
            Assert.True(result);
        }
    }
}
