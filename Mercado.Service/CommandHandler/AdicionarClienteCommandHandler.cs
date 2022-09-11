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

namespace Mercado.Application.Command
{
    public class AdicionarClienteCommandHandler : IRequestHandler<AdicionarClienteCommand, ClienteViewModel>
    {
        private readonly IClienteRepositorio _iclienteRepositorio;
        private readonly IMapper _mapper;

        public AdicionarClienteCommandHandler(IClienteRepositorio iclienteRepositorio, IMapper mapper)
        {
            _iclienteRepositorio = iclienteRepositorio;
            _mapper = mapper;
        }

        public Task<ClienteViewModel> Handle(AdicionarClienteCommand request, CancellationToken cancellationToken)
        {
            var mapClienteRequest = _mapper.Map<Cliente>(request);
            var cliente = _iclienteRepositorio.Adicionar(mapClienteRequest);
            var mapcliente = _mapper.Map<ClienteViewModel>(cliente);
            return Task.FromResult(mapcliente);
        }
    }
}
