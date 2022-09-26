using MediatR;
using System.Threading;
using System.Threading.Tasks;


namespace Mercado.Entidades.Events
{
    public class ClienteEventHandler :
        INotificationHandler<ClienteRemovedEvent>,
        INotificationHandler<ClienteUpdatedEvent>,
        INotificationHandler<ClienteRegisteredEvent>
    {


        public Task Handle(ClienteUpdatedEvent message, CancellationToken cancellationToken)
        {

            return Task.CompletedTask;
        }

        public Task Handle(ClienteRegisteredEvent message, CancellationToken cancellationToken)
        {

            return Task.CompletedTask;
        }

        public Task Handle(ClienteRemovedEvent message, CancellationToken cancellationToken)
        {

            return Task.CompletedTask;
        }
    }
}