using Domain;
using Domain.Employees;
using Infrastructure.ExportBehaviour;

namespace GitHydra.Tests
{
    public class SprintTest
    {
        private readonly StringWriter _writer = new();

        public SprintTest()
        {
            Console.SetOut(_writer);
        }

        [Fact]
        public void Export_Sprint_To_PDF()
        {
            var exportMethod = new ExportPDF();
            var sprint = new ReleaseSprint("Login feature", DateTime.Now, DateTime.Now, new ScrumMaster("Mark", "Mark@gmail.com"), exportMethod);

            sprint.Export();

            Assert.Equal("Exporting sprint Login feature to PDF...", _writer.ToString().Trim());
        }

        [Fact]
        public void Export_Sprint_To_PNG()
        {
            var exportMethod = new ExportPNG();
            var sprint = new ReleaseSprint("Login feature", DateTime.Now, DateTime.Now, new ScrumMaster("Mark", "Mark@gmail.com"), exportMethod);

            sprint.Export();

            Assert.Equal("Exporting sprint Login feature to PNG...", _writer.ToString().Trim());
        }
    }
}