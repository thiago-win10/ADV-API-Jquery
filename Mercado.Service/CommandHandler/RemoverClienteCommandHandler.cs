using AutoMapper;
using MediatR;
using Mercado.Application.CommandHandler;
using Mercado.DomainCore.Bus;
using Mercado.DomainCore.Notifications;
using Mercado.Entidades.Events;
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
    public class RemoverClienteCommandHandler : CommandHandlerBase, IRequestHandler<RemoverClienteCommand, bool>
    {
        private readonly IClienteRepositorio _iclienteRepositorio;
        private readonly IMapper _mapper;
        private readonly IMediatorHandler Bus;


        public RemoverClienteCommandHandler(IClienteRepositorio iclienteRepositorio, IMapper mapper,
            IUnitOfWork uow,
            IMediatorHandler bus,
            INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
        _iclienteRepositorio = iclienteRepositorio;
        _mapper = mapper;

        }

        public Task<bool> Handle(RemoverClienteCommand request, CancellationToken cancellationToken)
        {
            

            var isDeleted = _iclienteRepositorio.Remover(request.ClienteId);

            if (Commit())
            {
                Bus.RaiseEvent(new ClienteRemovedEvent(request.ClienteId));
            }

            return Task.FromResult(isDeleted);
        }
    }
}
