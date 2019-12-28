using System.Threading;
using System.Threading.Tasks;

namespace Alamut.Abstractions.Messaging
{
    public interface IDynamicMessageHandler 
    {
        Task Handle(dynamic message, CancellationToken token);
    }
}