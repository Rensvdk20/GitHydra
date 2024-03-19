﻿using Infrastructure.DevOps;
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
            var adapter = new DevOpsAdapter(pipelineMock.Object);

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
            var adapter = new DevOpsAdapter(pipelineMock.Object);

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
            var adapter = new DevOpsAdapter(pipelineMock.Object);

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
            var adapter = new DevOpsAdapter(pipelineMock.Object);

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
            var adapter = new DevOpsAdapter(pipelineMock.Object);

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
            var adapter = new DevOpsAdapter(pipelineMock.Object);

            // Act
            adapter.GetUtility();

            // Assert
            pipelineMock.Verify(p => p.Utility(), Times.Once);
        }
    }
}