using Domain;
using Domain.Employees;
using Infrastructure.ExportBehaviour;

namespace GitHydra.Tests
{
    public class SprintTest : IDisposable
    {
        private readonly StringWriter _writer;
        private readonly TextWriter _originalConsoleOut;

        public SprintTest()
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
        public void Export_Sprint_To_PDF()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var exportMethod = new ExportPDF();
            var sprint = new ReleaseSprint("Login feature", DateTime.Now, DateTime.Now, new ScrumMaster("Mark", "Mark@gmail.com"), exportMethod);

            // Act
            sprint.Export();

            // Assert
            Assert.Equal("Exporting sprint Login feature to PDF...", writer.ToString().Trim());
        }

        [Fact]
        public void Export_Sprint_To_PNG()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var exportMethod = new ExportPNG();
            var sprint = new ReleaseSprint("Login feature", DateTime.Now, DateTime.Now, new ScrumMaster("Mark", "Mark@gmail.com"), exportMethod);

            // Act
            sprint.Export();

            // Assert
            Assert.Equal("Exporting sprint Login feature to PNG...", writer.ToString().Trim());
        }
    }
}