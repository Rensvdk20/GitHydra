namespace Domain.BacklogItemState
{
    public class BacklogItemTodo : IBacklogItemState
    {
        private readonly IBacklogItemContext _context;

        public BacklogItemTodo(IBacklogItemContext context)
        {
            this._context = context;
        }

        public void MoveToTodo()
        {
            throw new InvalidOperationException("Backlog Item is already in Todo");
        }

        public void MoveToDoing()
        {
            _context.SetState(new BacklogItemDoing(_context));
        }

        public void MoveToReadyForTesting()
        {
            throw new InvalidOperationException("Backlog Item status is 'Todo'. Move Backlog Item to 'Doing' first");
        }

        public void MoveToTesting()
        {
            throw new InvalidOperationException("Cannot test Backlog Item when status is 'Todo'");
        }

        public void MoveToTested()
        {
            throw new InvalidOperationException("Backlog Item status is 'Todo'. Move Backlog Item to 'Doing' first");
        }

        public void MoveToDone()
        {
            throw new InvalidOperationException("Cannot finish Backlog Item when status is 'Todo'");
        }
    }
}
