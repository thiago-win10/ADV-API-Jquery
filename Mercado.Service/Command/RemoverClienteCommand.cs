using MediatR;
using Mercado.Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mercado.Application.Command
{
    public class RemoverClienteCommand : IRequest<bool> 
    {
        public Guid ClienteId { get; set; }
    }
}
