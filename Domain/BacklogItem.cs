using Domain.Employees;
using DomainServices;

namespace Domain
{
    public class BacklogItem
    {
        private IEnumerable<Activity> activities = new List<Activity>();
        private Developer developer;
        private IEnumerable<IThread> threads = new List<IThread>();

        public BacklogItem(Developer developer)
        {
            this.developer = developer;
        }
    }
}
