namespace Domain
{
    public class Message : IMessage
    {
        private IEmployee author;
        private String content;
        private DateTime timestamp = new DateTime();
        private List<IMessage> messages = new();
        private IThread thread;

        public Message(IEmployee author, string content, IThread thread)
        {
            this.author = author;
            this.content = content;
            this.thread = thread;
        }

        public void AddMessage(IMessage message)
        {
            if (thread.IsChangeable())
            {
                messages.Add(message);
                thread.NotifyTeamMembersOfNewMessage();
            }
        }

        public List<IMessage> GetAllMessages()
        {
            return this.messages;
        }

        public IEmployee GetAuthor()
        {
            return this.author;
        }

        public string GetContent()
        {
            return this.content;
        }

        public IThread GetThread()
        {
            return this.thread;
        }
    }
}
