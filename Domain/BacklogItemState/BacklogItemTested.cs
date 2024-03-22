using DomainServices;

namespace Domain.BacklogItemState
{
    public class BacklogItemTested : IBacklogItemState
    {
        private readonly IBacklogItemContext _context;

        public BacklogItemTested(IBacklogItemContext context)
        {
            this._context = context;
        }

        public void MoveToTodo()
        {
            throw new InvalidOperationException("Cannot put Backlog Item back to 'Todo' when tested");
        }

        public void MoveToDoing()
        {
            throw new InvalidOperationException("Cannot put Backlog Item back to 'Doing' when tested");
        }

        public void MoveToReadyForTesting()
        {
            _context.SetState(new BacklogItemReadyForTesting(_context));
        }

        public void MoveToTesting()
        {
            throw new InvalidOperationException("Cannot put Backlog Item back to 'Testing' when tested");
        }

        public void MoveToTested()
        {
            throw new InvalidOperationException("Backlog Item already has status 'Tested'");
        }

        public void MoveToDone()
        {
            _context.SetState(new BacklogItemDone(_context));
        }
    }
}
