using Domain.Employees;
using DomainServices;

namespace Domain
{
    public class ReleaseSprint : ISprint
    {
        private String name;
        private DateTime startDate;
        private DateTime endDate;
        private Boolean completed;
        private SprintBacklog sprintBacklog;
        private IExportStrategy exportStrategy;

        private ISprintState sprintState;
        private IEnumerable<Developer> developers;
        private ScrumMaster scrumMaster;

        public ReleaseSprint(string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, IExportStrategy exportStrategy)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.exportStrategy = exportStrategy;
            this.scrumMaster = scrumMaster;
        }

        public string toString()
        {
            return this.name;
        }

        public void Export()
        {
            this.exportStrategy.Export(this);
        }
    }
}
