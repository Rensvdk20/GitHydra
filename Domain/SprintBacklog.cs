using DomainServices;

namespace Domain
{
    public class SprintBacklog
    {
        private IEnumerable<BacklogItem> backlogItems;

        public void CompleteSprint()
        {
            foreach (var backlogItem in backlogItems)
            {
                backlogItem.CompleteSprint();
            }
        }
    }
}
