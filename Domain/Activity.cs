using Domain.Employees;

namespace Domain
{
    public class Activity
    {
        private string name;
        private Developer developer;
        private BacklogItem backlogItem;

        public Activity(string name, Developer developer, BacklogItem backlogItem)
        {
            this.name = name;
            this.developer = developer;
            this.backlogItem = backlogItem;
        }
        
        public bool GetActivityLocked()
        {
            return this.activityLocked;
        }

        public void SetDeveloper(Developer developer)
        {
            if (IsChangeable())
            {
                this.developer = developer;
            }
        }

        public Developer GetDeveloper()
        {
            return this.developer;
        }
      
        public bool IsChangeable()
        {
            return backlogItem.IsChangeable();
        }
    }
}
