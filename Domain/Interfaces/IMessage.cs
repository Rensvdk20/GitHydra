namespace Domain
{
    public interface IMessage
    {
        void addMessage(IMessage message);
        List<IMessage> GetAllMessages();
    }
}
