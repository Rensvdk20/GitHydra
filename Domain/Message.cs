using DomainServices;

namespace Domain
{
    public class Message : IMessage
    {
        private IEmployee author;
        private String content;
        private DateTime timestamp = new DateTime();

        public Message(IEmployee author, string content)
        {
            this.author = author;
            this.content = content;
        }
    }
}
