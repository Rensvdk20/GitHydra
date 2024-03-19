using Domain.Employees;
using DomainServices;

namespace Domain
{
    public class BacklogItem :  IBacklogItemContext
    {
        private IEnumerable<Activity> _activities;
        private IEnumerable<IThread> _threads;
        private readonly Developer developer;

        private IBacklogItemState _currentState;

        public BacklogItem(Developer developer)
        {
            // Parameters
            this.developer = developer;

            // Defaults
            this._activities = new List<Activity>();
            this._threads = new List<IThread>();
            this._currentState = new BacklogItemState.BacklogItemTodo(this);
        }

        public void SetState(IBacklogItemState state)
        {
            this._currentState = state;
        }

        public IBacklogItemState GetState() => _currentState;

        public void MoveToDoing() => this._currentState!.MoveToDoing();
    }
}
