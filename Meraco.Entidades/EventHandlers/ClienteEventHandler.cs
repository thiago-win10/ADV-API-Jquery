using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;


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