namespace Domain
{
    public interface IMessage
    {
        void AddMessage(IMessage message);
        List<IMessage> GetAllMessages();
    }
}
