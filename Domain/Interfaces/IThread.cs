namespace Domain
{
    public interface IThread
    {
        public void AddMessage(IMessage message);

        public void CloseThread();
    }
}
