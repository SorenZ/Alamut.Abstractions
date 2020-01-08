using Alamut.Abstractions.Structure;

namespace Alamut.Abstractions.Messaging.Messages
{
    /// <summary>
    /// it would publish to the respond of a message that requests an an acknowledge (AcknowledgeRequested = true)
    /// the Id must be set with the same Id of original message
    /// </summary>
    public class AcknowledgeMessage 
    {
        /// <summary>
        /// it must populated with the same Id of the original message that requested an acknowledge
        /// </summary>
        /// <value></value>
        public string Id { get; set; }
        
        /// <summary>
        /// provides the information about how the message(that requested acknowledge) Has been processed 
        /// </summary>
        public Result Result { get; set; }
    }
}