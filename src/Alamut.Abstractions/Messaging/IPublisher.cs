using System.Threading.Tasks;
using Alamut.Abstractions.Messaging.MessageContracts;

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
        /// <remarks>
        /// Note: Awaiting the asynchronous produce request below prevents flow of execution
        /// from proceeding until the acknowledgement from the broker is received (at the 
        /// expense of low throughput).
        /// </remarks>
        Task PublishAsync(string topic, string message);
        
        /// <summary>
        /// publish given message to specified topic
        /// serialize message to JSON (with default serializer provider)
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <remarks>
        /// Note: Awaiting the asynchronous produce request below prevents flow of execution
        /// from proceeding until the acknowledgement from the broker is received (at the 
        /// expense of low throughput).
        /// </remarks>
        Task PublishAsync(string topic, object message);
        
        /// <summary>
        /// publish given message to specified topic
        /// if IMessage.Id is not provided, generate a new unique Id for it
        /// serialize message to JSON (with default serializer provider)
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        /// <remarks>
        /// Note: Awaiting the asynchronous produce request below prevents flow of execution
        /// from proceeding until the acknowledgement from the broker is received (at the 
        /// expense of low throughput).
        /// </remarks>
        Task PublishAsync(string topic, IMessage message);

        /// <summary>
        /// publish given message to specified topic
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        void Publish(string topic, string message);
        
        /// <summary>
        /// publish given message to specified topic
        /// serialize message to JSON (with default serializer provider)
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        void Publish(string topic, object message);
        
        /// <summary>
        /// publish given message to specified topic
        /// if IMessage.Id is not provided, generate a new unique Id for it
        /// serialize message to JSON (with default serializer provider)
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        void Publish(string topic, IMessage message);
    }
}