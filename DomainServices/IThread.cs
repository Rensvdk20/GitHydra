namespace DomainServices
{
    public interface IThread
    {
        public void AddMessage(IMessage message);

        public void CloseThread();
    }
}
