namespace Alamut.Abstractions.Messaging
{
    public class Message<T> : IMessage
    {
        public string Id { get; set; }
        public string EventName { get; set; }
        public bool AcknowledgeRequested { get; set; }
        public string AcknowledgeTopic { get; set; }
        public T Data { get; set; }
    }
}