using DomainServices;

namespace Domain.BacklogItemState
{
    public class BacklogItemDone : IBacklogItemState
    {
        private readonly IBacklogItemContext _context;

        public BacklogItemDone(IBacklogItemContext context)
        {
            this._context = context;
        }

        public void MoveToTodo()
        {
            throw new InvalidOperationException("Backlog Item is done");
        }

        public void MoveToDoing()
        {
            throw new InvalidOperationException("Backlog Item is done");
        }

        public void MoveToReadyForTesting()
        {
            throw new InvalidOperationException("Backlog Item is done");
        }

        public void MoveToTesting()
        {
            throw new InvalidOperationException("Backlog Item is done");
        }

        public void MoveToTested()
        {
            throw new InvalidOperationException("Backlog Item is done");
        }

        public void MoveToDone()
        {
            throw new InvalidOperationException("Backlog Item is already done");
        }
    }
}
