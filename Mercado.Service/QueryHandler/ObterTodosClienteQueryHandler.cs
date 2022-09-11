using AutoMapper;
using MediatR;
using Mercado.Entidades.Models;
using Mercado.Entidades.ViewModels;
using Mercado.Infraestrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mercado.Application.Query
{
    public class ObterTodosClienteQueryHandler : IRequestHandler<ObterTodosClienteQuery, List<ClienteViewModel>>
    {
        private readonly IClienteRepositorio _iclienteRepositorio;
        private readonly IMapper _mapper;

        public ObterTodosClienteQueryHandler(IClienteRepositorio iclienteRepositorio, IMapper mapper)
        {
            _iclienteRepositorio = iclienteRepositorio;
            _mapper = mapper;
        }

        public Task<List<ClienteViewModel>> Handle(ObterTodosClienteQuery request, CancellationToken cancellationToken)
        {
            var clientelist = _iclienteRepositorio.ObterTodos();
            var mapclienteList = _mapper.Map<List<ClienteViewModel>>(clientelist);
            return Task.FromResult(mapclienteList);            
        }
    }
}
