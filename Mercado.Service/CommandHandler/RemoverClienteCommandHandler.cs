using AutoMapper;
using MediatR;
using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Mercado.Application.Command
{
    public class RemoverClienteCommandHandler : IRequestHandler<RemoverClienteCommand, bool>
    {
        private readonly IClienteRepositorio _iclienteRepositorio;
        private readonly IMapper _mapper;

    public RemoverClienteCommandHandler(IClienteRepositorio iclienteRepositorio, IMapper mapper)
    {
        _iclienteRepositorio = iclienteRepositorio;
        _mapper = mapper;
    }

        public Task<bool> Handle(RemoverClienteCommand request, CancellationToken cancellationToken)
        {
            var isDeleted = _iclienteRepositorio.Remover(request.ClienteId);
            return Task.FromResult(isDeleted);
        }
    }
}
