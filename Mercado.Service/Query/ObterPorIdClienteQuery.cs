using MediatR;
using Mercado.Entidades.ViewModels;
using System;

namespace Mercado.Application.Query
{
    public class ObterPorIdClienteQuery : IRequest<ClienteViewModel>
    {
        public Guid ClienteId { get; set; }

    }
}
