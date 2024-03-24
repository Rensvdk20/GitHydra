using Domain;
using Domain.Interfaces;

namespace Infrastructure.Listeners
{
    public class SlackSubscriber : ISubscriber
    {
        public void Notify(string message, IEmployee employee)
        {
            Console.WriteLine($"Slack message for: {employee}\n Message: {message}");
        }
    }
}
