using Domain.Employees;

namespace Domain
{
    public class BacklogItem :  IBacklogItemContext
    {
        private string name;

        private List<Activity> _activities;
        private List<IThread> _threads;
        private Developer developer;
        private bool backlogItemLocked = false;
        private IBacklogItemState _currentState;
        private SprintBacklog sprintBacklog;

        public BacklogItem(string name, Developer developer, SprintBacklog sprintBacklog)
        {
            // Parameters
            this.name = name;
            this.developer = developer;

            // Defaults
            this._activities = new List<Activity>();
            this._threads = new List<IThread>();
            this._currentState = new BacklogItemState.BacklogItemTodo(this);
            this.sprintBacklog = sprintBacklog;
        }

        public void SetState(IBacklogItemState state)
        {
            this._currentState = state;
        }

        public IBacklogItemState GetState() => _currentState;

        public void MoveToDoing() => this._currentState!.MoveToDoing();

        public void AddActivity(string name, Developer developer)
        {
            if (sprintBacklog.GetSprint().GetState().GetType().Name.Equals("ReleaseSprintCreated"))
            {
                _activities.Add(new Activity(name, developer, this));
            }
        }

        public SprintBacklog GetSprintBacklog()
        {
            return this.sprintBacklog;
        }

        public void AddThread(Thread thread)
        {
            if (!backlogItemLocked)
            {
                _threads.Add(thread);
            }
        }

        public void SetDeveloper(Developer developer)
        {
            this.developer = developer;
        }
    }
}
