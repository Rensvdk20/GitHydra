using System.Text;
using Infrastructure.DevOps;

namespace GitHydra.Tests
{
    public class DevOpsPipelineTest : IDisposable
    {

        private readonly StringWriter _writer;
        private readonly TextWriter _originalConsoleOut;

        public DevOpsPipelineTest()
        {
            _writer = new StringWriter();
            _originalConsoleOut = Console.Out;
            Console.SetOut(_writer);
        }

        public void Dispose()
        {
            Console.SetOut(_originalConsoleOut);
            _writer.Dispose();
        }

        [Fact]
        public void Source_Method_Calls_Console_WriteLine()
        {
            // Arrange
            var expectedOutput = "Source method called";
            var consoleOutput = new StringBuilder();
            var stringWriter = new StringWriter(consoleOutput);
            Console.SetOut(stringWriter);

            var pipeline = new DevOpsPipeline();

            // Act
            pipeline.Source();

            // Assert
            Assert.Contains(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void Package_Method_Calls_Console_WriteLine()
        {
            // Arrange
            var expectedOutput = "Package method called";
            var consoleOutput = new StringBuilder();
            var stringWriter = new StringWriter(consoleOutput);
            Console.SetOut(stringWriter);

            var pipeline = new DevOpsPipeline();

            // Act
            pipeline.Package();

            // Assert
            Assert.Contains(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void Test_Method_Calls_Console_WriteLine()
        {
            // Arrange
            var expectedOutput = "Test method called";
            var consoleOutput = new StringBuilder();
            var stringWriter = new StringWriter(consoleOutput);
            Console.SetOut(stringWriter);

            var pipeline = new DevOpsPipeline();

            // Act
            pipeline.Test();

            // Assert
            Assert.Contains(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void Analyse_Method_Calls_Console_WriteLine()
        {
            // Arrange
            var expectedOutput = "Analyse method called";
            var consoleOutput = new StringBuilder();
            var stringWriter = new StringWriter(consoleOutput);
            Console.SetOut(stringWriter);

            var pipeline = new DevOpsPipeline();

            // Act
            pipeline.Analyse();

            // Assert
            Assert.Contains(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void Deployment_Method_Calls_Console_WriteLine()
        {
            // Arrange
            var expectedOutput = "Deployment method called";
            var consoleOutput = new StringBuilder();
            var stringWriter = new StringWriter(consoleOutput);
            Console.SetOut(stringWriter);

            var pipeline = new DevOpsPipeline();

            // Act
            pipeline.Deployment();

            // Assert
            Assert.Contains(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void Utility_Method_Calls_Console_WriteLine()
        {
            // Arrange
            var expectedOutput = "Utility method called";
            var consoleOutput = new StringBuilder();
            var stringWriter = new StringWriter(consoleOutput);
            Console.SetOut(stringWriter);

            var pipeline = new DevOpsPipeline();

            // Act
            pipeline.Utility();

            // Assert
            Assert.Contains(expectedOutput, consoleOutput.ToString());
        }
    }
}
