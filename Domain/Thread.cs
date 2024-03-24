namespace Domain
{
    public class Thread : IThread
    {
        private string topic;
        private bool status;
        private BacklogItem backlogItem;
        private List<IMessage> messages = new();

        public Thread(string topic, BacklogItem backlogItem)
        {
            this.topic = topic;
            this.backlogItem = backlogItem;
            this.status = true;
        }

        public void AddMessage(IMessage message)
        {
            if (this.IsChangeable())
            {
                messages.Add(message);
            }

            throw new InvalidOperationException("Can't add a message when the thread/backlog item/sprint is closed");
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

        public bool IsChangeable()
        {
            return this.backlogItem.IsChangeable() || this.status;
        }

        public String GetTopic()
        {
            return topic;
        }
    }
}
