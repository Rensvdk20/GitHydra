using Domain.Employees;

namespace Domain
{
    public class BacklogItem :  IBacklogItemContext
    {
        private string name;

        private List<Activity> _activities;
        private List<IThread> _threads;
        private Developer developer;
        private IBacklogItemState _currentState;
        private SprintBacklog sprintBacklog;

        public BacklogItem(string name, Developer developer)
        {
            // Parameters
            this.developer = developer;

            // Defaults
            this._activities = new List<Activity>();
            this._threads = new List<IThread>();
            this._currentState = new BacklogItemState.BacklogItemTodo(this);
        }

        public BacklogItem(string name, Developer developer, SprintBacklog sprintBacklog)
        {
            // Parameters
            this.name = name;
            this.developer = developer;
            this.sprintBacklog = sprintBacklog;

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

        public void AddActivity(string name, Developer developer)
        {
            if (!IsChangeable())
            {
                Console.WriteLine("Can't add activities, because the sprint has already started/finished");
                return;
            }

            _activities.Add(new Activity(name, developer, this));
        }

        public List<Activity> GetActivities()
        {
            return _activities;
        }

        public SprintBacklog GetSprintBacklog()
        {
            return this.sprintBacklog;
        }

        public void AddThread(Thread thread)
        {
            if (!IsChangeable())
            {
                Console.WriteLine("Can't add threads, because the sprint has already started/finished");
                return;
            }

            _threads.Add(thread);
        }

        public List<IThread> GetAllThreads()
        {
            return _threads;
        }

        public void SetDeveloper(Developer developer)
        {
            if (!IsChangeable())
            {
                Console.WriteLine("Can't change the developer, because the sprint has already started");
                return;
            }

            this.developer = developer;
        }

        public Developer GetDeveloper()
        {
            return this.developer;
        }

        public virtual bool IsChangeable()
        {
            return sprintBacklog.GetSprint().GetState().GetType().Name.Equals("SprintCreated");
        }
    }
}
