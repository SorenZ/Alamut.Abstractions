using System.Threading;
using System.Threading.Tasks;

namespace Alamut.Abstractions.Messaging
{
    public interface IMessageHandler<TMessage>
    {
        Task Handle(TMessage message, CancellationToken token);
    }
}