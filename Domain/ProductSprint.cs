﻿using Domain.Employees;
using DomainServices;

namespace Domain
{
    public class ProductSprint : ISprint
    {
        private String name;
        private DateTime startDate;
        private DateTime endDate;
        private Boolean completed;
        private SprintBacklog sprintBacklog;

        private ISprintState sprintState;
        private IEnumerable<Developer> developers;
        private ScrumMaster scrumMaster;

        public ProductSprint(string name, DateTime startDate, DateTime endDate, ScrumMaster scrumMaster)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
            this.scrumMaster = scrumMaster;
        }
    }
}
