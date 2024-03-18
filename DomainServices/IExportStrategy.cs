using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices
{
    public interface IExportStrategy
    {
        void ExportToPNG();
        void ExportToPDF();
    }
}
