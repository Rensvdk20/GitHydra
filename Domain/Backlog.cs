using Domain.Employees;

namespace Domain
{
    public class Backlog
    {
        private List<BacklogItem> backlogItems;

        public Backlog()
        {

            this.backlogItems = new List<BacklogItem>();
        }

        public void AddBacklogItem(string name, Developer developer)
        {

            backlogItems.Add(new BacklogItem(name, developer));
        }
    }
}
