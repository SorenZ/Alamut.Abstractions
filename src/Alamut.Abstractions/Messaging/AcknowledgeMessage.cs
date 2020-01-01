using Alamut.Abstractions.Structure;

namespace Alamut.Abstractions.Messaging
{
    public class AcknowledgeMessage : IMessage
    {
        public string Id { get; set; }
        public string EventName { get; set; }
        public bool AcknowledgeRequested { get; set; }
        public string AcknowledgeTopic { get; set; }
        public Result Result { get; set; }
    }
}