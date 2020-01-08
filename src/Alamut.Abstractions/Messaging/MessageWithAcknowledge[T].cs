namespace Alamut.Abstractions.Messaging
{
    /// <summary>
    /// provides a message with an acknowledge request
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MessageWithAcknowledge<T> : IMessageWithAcknowledge
    {
        /// <inheritdoc />
        public string Id { get; set; }

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