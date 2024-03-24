using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SprintState
{
    public class SprintCancelled : ISprintState
    {
        private readonly ISprintContext _sprint;

        public SprintCancelled(ISprintContext sprint)
        {
            _sprint = sprint;
            _sprint.NotifySubscribers($"Sprint {sprint} has been cancelled", "product owner");
            _sprint.NotifySubscribers($"Sprint {sprint} has been cancelled", "scrum master");
        }
        public void StartSprint()
        {
            throw new InvalidOperationException("Cannot start a cancelled sprint");
        }

        public void CancelSprint()
        {
            throw new InvalidOperationException("Sprint is already cancelled");
        }

        public void FinishSprint()
        {
            throw new InvalidOperationException("Cannot finish a cancelled sprint");
        }

        public void Change(string name, DateTime? startDate, DateTime? endDate)
        {
            throw new InvalidOperationException("Value cannot be changed, sprint is cancelled");
        }
    }
}
