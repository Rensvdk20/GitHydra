using Domain;
using Domain.Employees;
using Infrastructure.DevOps;
using Infrastructure.ExportBehaviour;
using System.Text;

namespace GitHydra.Tests
{
    public class ExportTest
    {
        [Fact]
        public void Export_Sprint_To_PDF()
        {
            // Arrange
            var expectedOutput = "Exporting sprint Login feature to PDF...";
            var consoleOutput = new StringBuilder();
            var stringWriter = new StringWriter(consoleOutput);
            Console.SetOut(stringWriter);

            var exportMethod = new ExportPDF();
            var devOpsPipelineService = new DevOpsPipelineService(new DevOpsAdapter(new DevOpsPipeline(), new DevOpsGit()));
            var sprint = new ReleaseSprint("Login feature", DateTime.Now, DateTime.Now, new ScrumMaster("Mark", "Mark@gmail.com"), exportMethod, devOpsPipelineService);

            // Act
            sprint.Export();

            // Assert
            Assert.Contains(expectedOutput, consoleOutput.ToString());
        }

        [Fact]
        public void Export_Sprint_To_PNG()
        {
            // Arrange
            var expectedOutput = "Exporting sprint Login feature to PNG...";
            var consoleOutput = new StringBuilder();
            var stringWriter = new StringWriter(consoleOutput);
            Console.SetOut(stringWriter);

            var exportMethod = new ExportPNG();
            var devOpsPipelineService = new DevOpsPipelineService(new DevOpsAdapter(new DevOpsPipeline(), new DevOpsGit()));
            var sprint = new ReleaseSprint("Login feature", DateTime.Now, DateTime.Now, new ScrumMaster("Mark", "Mark@gmail.com"), exportMethod, devOpsPipelineService);

            // Act
            sprint.Export();

            // Assert
            Assert.Contains(expectedOutput, consoleOutput.ToString());
        }
    }
}