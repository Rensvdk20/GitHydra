namespace Domain
{
    public interface IThread
    {
        void AddMessage(IMessage message);
        List<IMessage> GetAllMessages();

        void CloseThread();
        bool GetStatus();
        BacklogItem GetBacklogItem();
        bool IsChangeable();
        String GetTopic();
        void NotifyTeamMembersOfNewMessage();
    }
}
