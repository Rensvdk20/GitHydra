using DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SprintState
{
    public class SprintInProgress : ISprintState
    {
        private readonly ISprint _sprint;

        public SprintInProgress(ISprint sprint)
        {
            _sprint = sprint;
        }
        public void StartSprint()
        {
            throw new InvalidOperationException("Sprint is already in progress");
        }

        public void CancelSprint()
        {
            this._sprint.CancelSprint();
        }

        public void FinishSprint()
        {
            this._sprint.FinishSprint();
        }

        public void Change(string name, DateTime? startDate, DateTime? endDate)
        {
            throw new InvalidOperationException("Value cannot be changed, sprint is in progress");
        }
    }
}
