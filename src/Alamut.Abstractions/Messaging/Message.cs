namespace Alamut.Abstractions.Messaging
{
    public class Message : IMessage
    {
        public string Id { get; set; }
        public string EventName { get; set; }
        public object Data { get; set; }
    }
}