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
    public class ObterPorIdClienteQueryHandler : IRequestHandler<ObterPorIdClienteQuery, ClienteViewModel>
    {
        private readonly IClienteRepositorio _iclienteRepositorio;
        private readonly IMapper _mapper;

        public ObterPorIdClienteQueryHandler(IClienteRepositorio iclienteRepositorio , IMapper mapper)
        {
            _iclienteRepositorio = iclienteRepositorio;
            _mapper = mapper;
        }
        public async Task<ClienteViewModel> Handle(ObterPorIdClienteQuery request, CancellationToken cancellationToken)
        {
            var cliente = _iclienteRepositorio.ObterPorId(request.ClienteId);
            var mapProduct = _mapper.Map<ClienteViewModel>(cliente);
            return await Task.FromResult(mapProduct);


       
        }
    }
}
