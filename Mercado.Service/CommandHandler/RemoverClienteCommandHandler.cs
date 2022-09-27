using AutoMapper;
using MediatR;
<<<<<<< HEAD
using Mercado.Application.CommandHandler;
using Mercado.DomainCore.Bus;
using Mercado.DomainCore.Notifications;
using Mercado.Entidades.Events;
using Mercado.Entidades.Models;
=======
>>>>>>> 21313b52a2f5b3bcfce19be3bc189f69fb8c6e3a
using Mercado.Infraestrutura.Interface;
using System.Threading;
using System.Threading.Tasks;
namespace Mercado.Application.Command
{
    public class RemoverClienteCommandHandler : CommandHandlerBase, IRequestHandler<RemoverClienteCommand, bool>
    {
        private readonly IClienteRepositorio _iclienteRepositorio;
        private readonly IMapper _mapper;
        private readonly IMediatorHandler Bus;

<<<<<<< HEAD

        public RemoverClienteCommandHandler(IClienteRepositorio iclienteRepositorio, IMapper mapper,
            IUnitOfWork uow,
            IMediatorHandler bus,
            INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
        _iclienteRepositorio = iclienteRepositorio;
        _mapper = mapper;

=======
        public RemoverClienteCommandHandler(IClienteRepositorio iclienteRepositorio, IMapper mapper)
        {
            _iclienteRepositorio = iclienteRepositorio;
            _mapper = mapper;
>>>>>>> 21313b52a2f5b3bcfce19be3bc189f69fb8c6e3a
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
