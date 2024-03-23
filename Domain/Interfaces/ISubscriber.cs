namespace Domain.Interfaces
{
    public interface ISubscriber
    {
        public void Notify(string message, IEmployee employee);
    }
}
