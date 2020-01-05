using System.Threading;
using System.Threading.Tasks;

namespace Alamut.Abstractions.Messaging
{
    /// <summary>
    /// Dynamic Message Handler base interface
    /// </summary>
    public interface IDynamicMessageHandler 
    {
        Task Handle(dynamic message, CancellationToken token);
    }
}