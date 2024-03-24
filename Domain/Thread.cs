namespace Domain
{
    public class Thread : IThread
    {
        private String topic;
        private bool status;
        private List<IMessage> messages = new();

        public Thread(String topic)
        {
            this.topic = topic;
            this.status = true;
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

        public String GetTopic()
        {
            return topic;
        }
    }
}
