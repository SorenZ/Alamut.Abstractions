using System.Threading;
using System.Threading.Tasks;

namespace Alamut.Abstractions.Messaging
{
    public interface IStringMessageHandler
    {
        Task Handle(string message, CancellationToken token);
    }
}