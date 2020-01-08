namespace Alamut.Abstractions.Messaging.MessageContracts
{
    /// <summary>
    /// provides a message with an acknowledge request 
    /// </summary>
    public interface IMessageWithAcknowledge : IMessage
    {
        /// <summary>
        /// indicates whether the publisher requests approval
        /// </summary>
        /// <remarks>optional</remarks>
        bool AcknowledgeRequested { get; set; }
        
        /// <summary>
        /// defines the Topic that the AcknowledgeMessage should be published on it
        /// </summary>
        /// <remarks>optional</remarks>
        string AcknowledgeTopic { get; set; }
    }
}