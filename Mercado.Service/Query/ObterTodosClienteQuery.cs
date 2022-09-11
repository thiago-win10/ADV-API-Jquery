using MediatR;
using Mercado.Entidades.Models;
using Mercado.Entidades.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Application.Query
{
    public class ObterTodosClienteQuery : IRequest<List<ClienteViewModel>>
    {
        public Cliente cliente { get; set; }
    }
}
