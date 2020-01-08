namespace Alamut.Abstractions.Messaging
{
    /// <summary>
    /// provides basic structure for Messaging system
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Message<T> : IMessage
    {
        /// <inheritdoc />
        public string Id { get; set; }
        
        /// <summary>
        /// The actual data that moves through messaging system
        /// </summary>
        public T Body { get; set; }
    }

}