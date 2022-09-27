using Mercado.DomainCore;
using System;

namespace Mercado.Entidades.Events
{
    public class ClienteRegisteredEvent : Event
    {

        public ClienteRegisteredEvent(Guid id,string name, string email, DateTime datanasc, string cep)
        {
            ClienteId = id;
            NomeCompleto = name;
            Email = email;
            DataNascimento = datanasc;
            Cep = cep;
            AggregateId = id;
        }
        public Guid ClienteId { get; set; }

        public string NomeCompleto { get; private set; }

        public string Email { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public string Cep { get; private set; }
    }
}
