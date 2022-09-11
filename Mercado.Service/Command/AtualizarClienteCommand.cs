using MediatR;
using Mercado.Entidades.Models;
using Mercado.Entidades.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Application.Command
{
    public class AtualizarClienteCommand : IRequest<ClienteViewModel>
    {
        public Guid ClienteId { get; set; }

    }
}
