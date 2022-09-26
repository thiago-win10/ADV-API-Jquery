using MediatR;
using Mercado.Entidades.ViewModels;
using System;

namespace Mercado.Application.Command
{
    public class AtualizarClienteCommand : IRequest<ClienteViewModel>
    {
        public Guid ClienteId { get; set; }

    }
}
