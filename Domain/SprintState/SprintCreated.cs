using DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SprintState
{
    public class SprintCreated : ISprintState
    {
        private readonly ISprintContext _sprint;

        public SprintCreated(ISprintContext sprint)
        {
            _sprint = sprint;
        }

        public void StartSprint()
        {
            this._sprint.SetSprintState(new SprintInProgress(_sprint));
        }

        public void CancelSprint()
        {
            this._sprint.SetSprintState(new SprintCancelled(_sprint));
        }

        public void FinishSprint()
        {
            throw new InvalidOperationException("Cannot finish a sprint that hasn't started");
        }

        public void Change(string? name = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            if (name != null) _sprint.SetName(name);
            if (startDate != null) _sprint.SetStartDate(startDate.Value);
            if (endDate != null) _sprint.SetEndDate(endDate.Value);
        }
    }
}
