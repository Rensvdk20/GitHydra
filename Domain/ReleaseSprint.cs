using Domain.Employees;
using Domain.SprintState;

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
            this.sprintState = new SprintCreated(this);
        }

        public override string ToString()
        {
            return this.name;
        }

        public SprintBacklog getBacklog()
        {
            return this.sprintBacklog;
        }

        public void Export()
        {
            this.exportStrategy.Export(this);
        }

        public void Change(string name, DateTime? startDate, DateTime? endDate)
        {
            sprintState.Change(name, startDate, endDate);
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetStartDate(DateTime startDate)
        {
            this.startDate = startDate;
        }

        public void SetEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }

        public ISprintState GetState()
        {
            return this.sprintState;
        }

        public void SetSprintState(ISprintState state)
        {
            this.sprintState = state;
        }

        public void SprintInProgress()
        {
            sprintBacklog.SprintInProgress();
        }
    }
}
