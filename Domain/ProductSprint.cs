﻿using Domain.Employees;
using Domain.Interfaces;
using Domain.Observer;
using Domain.SprintState;

namespace Domain
{
    public class ProductSprint : ISprint
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
        private SprintObservable _sprintObservable;
        private Project? project;
        private IDevOpsService? devOpsService;

        public ProductSprint(string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, IExportStrategy exportStrategy, IDevOpsService? devOpsService = null)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.sprintBacklog = new SprintBacklog(this);
            this.exportStrategy = exportStrategy;
            this.scrumMaster = scrumMaster;
            this.sprintState = new SprintCreated(this);
            this._sprintObservable = new SprintObservable(this);
            this.project = null;
            this.devOpsService = devOpsService;
        }

        public override string ToString()
        {
            return this.name;
        }

        public void Export()
        {
            this.exportStrategy.Export(this);
        }

        public void Change(string name, DateTime? startDate, DateTime? endDate)
        {
            sprintState.Change(name, startDate, endDate);
        }

        public SprintBacklog GetSprintBacklog()
        {
            return this.sprintBacklog;
        }

        public void Subscribe(ISubscriber subscriber)
        {
            this._sprintObservable.Subscribe(subscriber);
        }

        public ScrumMaster GetScrumMaster()
        {
            return this.scrumMaster;
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
        public void NotifySubscribers(string message, string employee)
        {
            this._sprintObservable.NotifySubscribers(message, employee);
        }

        public void SetProject(Project project)
        {
            this.project = project;
        }

        public Project GetProject()
        {
            return this.project ?? throw new InvalidOperationException("This sprint is not attached to a project");
        }

        public IDevOpsService? GetDevOpsService()
        {
            return devOpsService;
        }
    }
}
