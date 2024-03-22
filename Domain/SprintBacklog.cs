using Domain.Employees;

namespace Domain
{
    public class SprintBacklog
    {
        private ISprint sprint;
        private List<BacklogItem> backlogItems;

        public SprintBacklog(ISprint sprint)
        {

            this.backlogItems = new List<BacklogItem>();
            this.sprint = sprint;
        }

        public void AddBacklogItem(Developer developer)
        {

            backlogItems.Add(new BacklogItem(developer, this));
        }

        public void SprintInProgress()
        {
            foreach (var backlogItem in backlogItems)
            {
                backlogItem.SprintInProgress();
            }
        }

        public ISprint GetSprint()
        {
            return sprint;
        }
    }
}
