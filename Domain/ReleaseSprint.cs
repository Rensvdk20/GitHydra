﻿using Domain.Employees;
using Domain.Interfaces;
using Domain.Observer;
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
        private string reviewSummary;

        private ISprintState sprintState;
        private ScrumMaster scrumMaster;
        private SprintObservable _sprintObservable;
        private Project? project;
        private IDevOpsPipelineService devOpsPipelineService;

        public ReleaseSprint(string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster, IExportStrategy exportStrategy, IDevOpsPipelineService devOpsPipelineService)
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
            this.devOpsPipelineService = devOpsPipelineService;
        }

        public override string ToString()
        {
            return this.name;
        }

        public string GetReviewSummary()
        {
            return this.reviewSummary;
        }

        public SprintBacklog GetSprintBacklog()
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

        public DateTime GetStartDate()
        {
            return this.startDate;
        }

        public void SetEndDate(DateTime endDate)
        {
            this.endDate = endDate;
        }

        public DateTime GetEndDate()
        {
            return this.endDate;
        }

        public ISprintState GetState()
        {
            return this.sprintState;
        }

        public void SetSprintState(ISprintState state)
        {
            this.sprintState = state;
        }

        public void Subscribe(ISubscriber subscriber)
        {
            this._sprintObservable.Subscribe(subscriber);
        }

        public ScrumMaster GetScrumMaster()
        {
            return this.scrumMaster;
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

        public void SetReviewSummary(string review)
        {
            this.reviewSummary = review;
        }

        public IDevOpsPipelineService GetDevOpsPipelineService()
        {
            return devOpsPipelineService;
        }

        public bool RunPipeline()
        {
            if (devOpsPipelineService != null)
            {
                return devOpsPipelineService.RunPipeline();
            }

            throw new InvalidOperationException("Sprint heeft geen pipeline");
        }
    }
}
