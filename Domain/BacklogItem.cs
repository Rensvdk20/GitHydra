using Domain.Employees;

namespace Domain
{
    public class BacklogItem :  IBacklogItemContext
    {
        private List<Activity> _activities;
        private List<IThread> _threads;
        private Developer developer;
        private bool backlogItemLocked = false;
        private IBacklogItemState _currentState;
        private SprintBacklog sprintBacklog;

        public BacklogItem(Developer developer, SprintBacklog sprintBacklog)
        {
            // Parameters
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

        public void AddActivity(Activity activity)
        {
            if (!backlogItemLocked)
            {
                _activities.Add(activity);
            }
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

        public void SprintInProgress()
        {
            backlogItemLocked = true;
            foreach (var activity in this._activities)
            {
                activity.LockActivity();
            }
        }

        public void test()
        {
            sprintBacklog.GetSprint().GetState();
        }
    }
}
