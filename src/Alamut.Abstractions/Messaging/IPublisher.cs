using System.Threading.Tasks;

namespace Alamut.Abstractions.Messaging
{
    /// <summary>
    /// publish a message to the Message Broker
    /// </summary>
    public interface IPublisher
    {
        /// <summary>
        /// publish given message to specified topic
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task Publish(string topic, string message);
        
        /// <summary>
        /// publish given message to specified topic
        /// serialize message to JSON (with default serializer provider)
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task Publish(string topic, object message);
        
        /// <summary>
        /// publish given message to specified topic
        /// if IMessage.Id is not provided, generate a new unique Id for it
        /// serialize message to JSON (with default serializer provider)
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        Task Publish(string topic, IMessage message);
    }
}