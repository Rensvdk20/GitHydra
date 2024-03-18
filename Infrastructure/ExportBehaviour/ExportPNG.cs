using DomainServices;

namespace Infrastructure.ExportBehaviour
{
    public class ExportPNG : IExportStrategy
    {
        public void Export(ISprint sprint)
        {
            Console.WriteLine($"Exporting sprint {sprint} to PNG...");
        }
    }
}
