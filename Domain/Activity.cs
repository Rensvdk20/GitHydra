using Domain.Employees;

namespace Domain
{
    public class Activity
    {
        private Developer developer;
        private bool activityLocked = false;

        public Activity(Developer developer)
        {
            this.developer = developer;
        }

        public void LockActivity() {
            activityLocked = true;
        }

        public void SetDeveloper(Developer developer)
        {
            if (!activityLocked)
            {
                this.developer = developer;
            }
        }
    }
}
