namespace Alamut.Abstractions.Messaging
{
    public interface IMessage
    {
        string Id { get; set; }
        string EventName { get; set; }
    }
}