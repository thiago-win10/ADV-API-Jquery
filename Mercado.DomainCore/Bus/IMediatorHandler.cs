using Mercado.DomainCore.Commands;
using System.Threading.Tasks;

namespace Mercado.DomainCore.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
