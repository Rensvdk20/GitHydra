namespace Domain
{
    public class Message : IMessage
    {
        private IEmployee author;
        private String content;
        private DateTime timestamp = new DateTime();
        private List<IMessage> messages = new();

        public Message(IEmployee author, string content)
        {
            this.author = author;
            this.content = content;
        }

        public void addMessage(IMessage message)
        {
            messages.Add(message);
        }

        public List<IMessage> GetAllMessages()
        {
            return this.messages;
        }
    }
}
