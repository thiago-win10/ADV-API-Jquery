using MediatR;
using System;
namespace Mercado.Application.Command
{
    public class RemoverClienteCommand : IRequest<bool>
    {
        public Guid ClienteId { get; set; }
    }
}
