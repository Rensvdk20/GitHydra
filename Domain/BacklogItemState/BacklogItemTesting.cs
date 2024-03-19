using DomainServices;

namespace Domain.BacklogItemState
{
    public class BacklogItemTesting : IBacklogItemState
    {
        private readonly IBacklogItemContext _context;

        public BacklogItemTesting(IBacklogItemContext context)
        {
            this._context = context;
        }

        public void MoveToTodo()
        {
            throw new InvalidOperationException("Cannot put Backlog Item back to 'Todo' while being tested");
        }

        public void MoveToDoing()
        {
            throw new InvalidOperationException("Cannot put Backlog Item back to 'Doing' while being tested");
        }

        public void MoveToReadyForTesting()
        {
            throw new InvalidOperationException("Cannot put Backlog Item back to 'Ready for testing' while being tested");
        }

        public void MoveToTesting()
        {
            throw new InvalidOperationException("Backlog Item already has status 'Testing'");
        }

        public void MoveToTested()
        {
            _context.SetState(new BacklogItemTested(_context));
        }

        public void MoveToDone()
        {
            throw new InvalidOperationException("Cannot finish Backlog Item when status is 'Testing'");
        }
    }
}
