namespace Alamut.Abstractions.Messaging.MessageContracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEventMessage : IMessage
    {
        /// <summary>
        /// indicates Publisher Event Name 
        /// </summary>
        /// <remarks>optional</remarks>
        string EventName { get; set; }
    }
}