using Domain.Interfaces;

namespace Domain.Observer
{
    public class SprintObservable: IObservable
    {
        private List<ISubscriber> _subscribers = new();
        private ISprint sprint;

        public SprintObservable(ISprint sprint)
        {
            this.sprint = sprint;
        }

        public void Subscribe(ISubscriber subscriber)
        {
            this._subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            this._subscribers.Remove(subscriber);
        }

        public void NotifySubscribers(string message, string employee)
        {
            List<IEmployee>? receivers = null;

            switch (employee.ToLower())
            {
                case "scrum master":
                    receivers = new List<IEmployee> { sprint.GetScrumMaster() };
                    break;
                case "product owner":
                    receivers = new List<IEmployee> { sprint.GetProject().GetProductOwner() };
                    break;
                case "testers":
                    receivers = sprint.GetProject().GetTesters().Cast<IEmployee>().ToList();
                    break;
            }

            if (receivers != null)
            {
                foreach (var subscriber in this._subscribers)
                {
                    foreach (var receiver in receivers)
                    {
                        subscriber.Notify(message, receiver);
                    }
                }
            }
        }
    }
}
