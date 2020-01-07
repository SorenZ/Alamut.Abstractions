namespace Alamut.Abstractions.Messaging
{
    public class Message<T> : IMessage
    {
        public static Message<T> Build(T body) 
        => new Message<T> { Body = body };

        public string Id { get; set; }
        public string EventName { get; set; }
        public bool AcknowledgeRequested { get; set; }
        public string AcknowledgeTopic { get; set; }
        public T Body { get; set; }
    }
}