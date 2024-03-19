using DomainServices;

namespace Domain.BacklogItemState
{
    public class BacklogItemDoing : IBacklogItemState
    {
        private readonly IBacklogItemContext _context;

        public BacklogItemDoing(IBacklogItemContext context)
        {
            this._context = context;
        }

        public void MoveToTodo()
        {
            throw new InvalidOperationException("Cannot put Backlog Item back to 'Todo' when in progress");
        }

        public void MoveToDoing()
        {
            throw new InvalidOperationException("Backlog Item already has status 'Doing'");
        }

        public void MoveToReadyForTesting()
        {
            _context.SetState(new BacklogItemReadyForTesting(_context));
        }

        public void MoveToTesting()
        {
            throw new InvalidOperationException("Cannot test Backlog Item when status is 'Doing'");
        }

        public void MoveToTested()
        {
            throw new InvalidOperationException("Backlog Item status is 'Doing'. Move Backlog Item to 'Ready for testing' first");
        }

        public void MoveToDone()
        {
            throw new InvalidOperationException("Cannot finish Backlog Item when status is 'Doing'");
        }
    }
}
