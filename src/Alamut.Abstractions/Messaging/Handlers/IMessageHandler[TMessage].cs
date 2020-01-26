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
        Task Handle(TMessage message, CancellationToken token);
    }

    /// <summary>
    /// a flag interface to mark Message Handler
    /// </summary>
    public interface IMessageHandler
    {
        
    }
}