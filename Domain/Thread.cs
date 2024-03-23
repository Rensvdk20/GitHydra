namespace Domain
{
    public class Thread : IThread
    {
        private String topic;
        private bool status;
        private List<IMessage> messages = new();

        public Thread(String topic, bool status)
        {
            this.topic = topic;
            this.status = status;
        }

        public void AddMessage(IMessage message)
        {
            messages.Add(message);
        }

        public List<IMessage> GetAllMessages()
        {
            return messages;
        }

        public void CloseThread()
        {
            this.status = false;
        }

        public bool GetStatus()
        {
            return status;
        }
    }
}
