using Domain.Interfaces;

namespace Domain.Observer
{
    public class Observable
    {
        private List<ISubscriber> _subscribers = new();
        private ISprint sprint;

        public Observable(ISprint sprint)
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
            IEmployee? receiver = null;

            switch (employee.ToLower())
            {
                case
                    "scrum master":
                    receiver = sprint.GetScrumMaster();
                    break;
            }
            

            foreach (var subscriber in this._subscribers)
            {
                subscriber.Notify(message, receiver);
            }
        }
    }
}
