using MediatR;
using Mercado.DomainCore.Events;
using System;

namespace Mercado.DomainCore
{
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}