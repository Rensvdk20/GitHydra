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

        public BacklogItem AddBacklogItem(string name, Developer developer)
        {
            BacklogItem backlogItem = new BacklogItem(name, developer, this);
            backlogItems.Add(backlogItem);
            return backlogItem;
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
