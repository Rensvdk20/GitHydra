using DomainServices;

namespace Domain
{
    public class SprintBacklog
    {
        private IEnumerable<BacklogItem> backlogItems;

        public void SprintInProgress()
        {
            foreach (var backlogItem in backlogItems)
            {
                backlogItem.SprintInProgress();
            }
        }
    }
}
