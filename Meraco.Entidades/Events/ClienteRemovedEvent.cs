using Mercado.DomainCore;
using System;

namespace Mercado.Entidades.Events
{
    public class ClienteRemovedEvent : Event
    {
        public ClienteRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
