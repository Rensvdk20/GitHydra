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

        public void CloseThread()
        {
            this.status = false;
        }
    }
}
