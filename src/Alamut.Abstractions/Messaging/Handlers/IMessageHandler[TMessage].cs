using System.Threading;
using System.Threading.Tasks;

namespace Alamut.Abstractions.Messaging.Handlers
{
    /// <summary>
    /// message handler base interface
    /// </summary>
    /// <typeparam name="TMessage">the type of Message stored and provided by the Broker to handler</typeparam>
    /// <remark>inherited class should decorated with TopicsAttribute</remark>
    public interface IMessageHandler<TMessage> : IMessageHandler
    {
        /// <summary>
        /// provides a list of topics supposed to handle 
        /// </summary>
        /// <value></value>
        string[] Topics { get; }
        
        /// <summary>
        /// handles a received message 
        /// </summary>
        /// <param name="message">the message</param>
        /// <param name="token"></param>
        /// <returns></returns>
        Task Handle(TMessage message, CancellationToken token);
    }
}