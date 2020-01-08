namespace Alamut.Abstractions.Messaging.MessageContracts
{
    /// <summary>
    /// provides a base contract for every message in the Messaging system
    /// it's recommended to implement this contract for every message you want to send through Messaging system
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// provides a unique Id for the Message
        /// it would be generated by <see cref="IPublisher"> if Id does not provided 
        /// </summary>
        string Id { get; set; }
    }
}