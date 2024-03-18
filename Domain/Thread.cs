using DomainServices;

namespace Domain
{
    public class Thread : IThread
    {
        private String topic;
        private bool status;
        private IEnumerable<IMessage> messages = new List<IMessage>();

        public Thread(String topic, bool status)
        {
            this.topic = topic;
            this.status = status;
        }

        public void AddMessage(IMessage message)
        {

        }

        public void CloseThread()
        {

        }
    }
}
