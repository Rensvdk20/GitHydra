using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SprintState
{
    public class SprintFinished : ISprintState
    {
        private readonly ISprintContext _sprint;

        public SprintFinished(ISprintContext sprint)
        {
            _sprint = sprint;

            if (sprint.GetReviewSummary() == null)
            {
                throw new InvalidOperationException("Cannot finish a sprint that doesn't have a review summary");
            }

            if (_sprint.RunPipeline())
            {
                _sprint.NotifySubscribers($"Pipeline has finished succesfully", "product owner");
                _sprint.NotifySubscribers($"Pipeline has finished succesfully", "scrum master");
            } else
            {
                _sprint.NotifySubscribers($"Pipeline has failed", "product owner");
                _sprint.NotifySubscribers($"Pipeline has failed", "scrum master");
            }

            _sprint.NotifySubscribers($"Sprint {sprint} is finished", "product owner");
            _sprint.NotifySubscribers($"Sprint {sprint} is finished", "scrum master");
        }

        public void StartSprint()
        {
            throw new InvalidOperationException("Cannot start a finished sprint");
        }

        public void CancelSprint()
        {
            throw new InvalidOperationException("Cannot cancel a finished sprint");
        }

        public void FinishSprint()
        {
            throw new InvalidOperationException("Sprint is already finished");
        }

        public void Change(string name, DateTime? startDate, DateTime? endDate)
        {
            throw new InvalidOperationException("Value cannot be changed, sprint is finished");
        }
    }
}
