namespace Domain.BacklogItemState
{
    public class BacklogItemReadyForTesting : IBacklogItemState
    {
        private readonly IBacklogItemContext _context;

        public BacklogItemReadyForTesting(IBacklogItemContext context)
        {
            this._context = context;
        }

        public void MoveToTodo()
        {
            _context.SetState(new BacklogItemTodo(_context));
        }

        public void MoveToDoing()
        {
            throw new InvalidOperationException("Cannot put Backlog Item back to 'Doing'. Move back to 'Todo' first");
        }

        public void MoveToReadyForTesting()
        {
            throw new InvalidOperationException("Backlog Item already has status 'Ready for testing'");
        }

        public void MoveToTesting()
        {
            _context.SetState(new BacklogItemTesting(_context));
        }

        public void MoveToTested()
        {
            throw new InvalidOperationException("Backlog Item status is 'Ready for testing'. Move Backlog Item to 'Testing' first");
        }

        public void MoveToDone()
        {
            throw new InvalidOperationException("Cannot finish Backlog Item when status is 'Ready for testing'");
        }
    }
}
