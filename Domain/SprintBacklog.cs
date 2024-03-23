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

        public void AddBacklogItem(string name, Developer developer)
        {

            backlogItems.Add(new BacklogItem(name, developer, this));
        }

        public ISprint GetSprint()
        {
            return sprint;
        }

        public List<BacklogItem> GetBacklogItems()
        {
            return backlogItems;
        }
    }
}
