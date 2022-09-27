using MediatR;
using Mercado.Entidades.Models;
using Mercado.Entidades.ViewModels;
using System.Collections.Generic;

namespace Mercado.Application.Query
{
    public class ObterTodosClienteQuery : IRequest<List<ClienteViewModel>>
    {
        public Cliente cliente { get; set; }
    }
}
