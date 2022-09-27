using AutoMapper;
using MediatR;
using Mercado.Application.CommandHandler;
using Mercado.DomainCore.Bus;
using Mercado.DomainCore.Notifications;
using Mercado.Entidades.Events;
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
    public class AtualizarClienteCommandHandler : CommandHandlerBase, IRequestHandler<AtualizarClienteCommand, ClienteViewModel>
    {
        private readonly IClienteRepositorio _iclienteRepositorio;
        private readonly IMapper _mapper;
        private readonly IMediatorHandler Bus;


        public AtualizarClienteCommandHandler(IClienteRepositorio iclienteRepositorio, IMapper mapper ,IMediatorHandler bus, IUnitOfWork uow,
                                                  INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)

        {
            _iclienteRepositorio = iclienteRepositorio;
            _mapper = mapper;
             Bus = bus;

        }
    public Task<ClienteViewModel> Handle(AtualizarClienteCommand request, CancellationToken cancellationToken)
        {
            var mapClienteRequest = _mapper.Map<Cliente>(request);
            var cliente = _iclienteRepositorio.Atualizar(mapClienteRequest);
            var mapcliente = _mapper.Map<ClienteViewModel>(cliente);

            var customer = new Cliente(Guid.NewGuid(), mapClienteRequest.NomeCompleto, mapClienteRequest.ClienteId,
             mapClienteRequest.Email, mapClienteRequest.Datanascimento, mapClienteRequest.Cep);

            if (Commit())
            {
                Bus.RaiseEvent(new ClienteUpdatedEvent(customer.ClienteId, customer.NomeCompleto, customer.Email, customer.Datanascimento, customer.Cep));
            }
            return Task.FromResult(mapcliente);
        }
    }
}
