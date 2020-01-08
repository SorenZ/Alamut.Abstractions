namespace Alamut.Abstractions.Messaging
{
    /// <summary>
    /// provides a full feature message data structure
    /// </summary>
    /// <typeparam name="T">the type of the body of actual data</typeparam>
    public class FullMessage<T> : IMessage, IMessageWithAcknowledge, IEventMessage
    {
        /// <inheritdoc />
        public string Id { get; set; }

        /// <inheritdoc />
        public string EventName { get; set; }

        /// <inheritdoc />
        public bool AcknowledgeRequested { get; set; }

        /// <inheritdoc />
        public string AcknowledgeTopic { get; set; }

        /// <summary>
        /// The actual data that moves through messaging system
        /// </summary>
        public T Body { get; set; }
    }

}