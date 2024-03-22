using Domain;

namespace Infrastructure.ExportBehaviour
{
    public class ExportPDF : IExportStrategy
    {
        public void Export(ISprint sprint)
        {
            Console.WriteLine($"Exporting sprint {sprint} to PDF...");
        }
    }
}
