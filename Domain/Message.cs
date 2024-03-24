namespace Domain
{
    public class Message : IMessage
    {
        private IEmployee author;
        private String content;
        private DateTime timestamp = new DateTime();
        private List<IMessage> messages = new();
        private Thread thread;

        public Message(IEmployee author, string content, Thread thread)
        {
            this.author = author;
            this.content = content;
            this.thread = thread;
        }

        public void addMessage(IMessage message)
        {
            if (thread.IsChangeable())
            {
                messages.Add(message);
            }
        }

        public List<IMessage> GetAllMessages()
        {
            return this.messages;
        }
    }
}
