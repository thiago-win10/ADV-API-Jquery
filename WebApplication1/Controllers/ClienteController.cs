using AutoMapper;
using log4net;
using MediatR;
using Mercado.Application.Command;
using Mercado.Application.Query;
using Mercado.Entidades.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Mercado.Web.Controllers
{
    public class ClienteController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly ILog _log;



        public ClienteController(IMediator mediator, IMapper mapper, ILog log)
        {
            _mediator = mediator;
            _mapper = mapper;
            _log = log;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {

            try
            {
                return Ok(await _mediator.Send(new ObterTodosClienteQuery()));
                _log.Info("Client obtained");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                _log.Error("Fail , Clients don´t obtained");

            }
        }
        [HttpGet]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            try
            {
                return Ok(await _mediator.Send(new ObterPorIdClienteQuery { ClienteId = id }));
                _log.Info("Client GetById");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                _log.Error("Fail , Client don´t obtained");

            }
        }
        [HttpPut]
        public async Task<IActionResult> Atualizar(Guid id, AtualizarClienteCommand atualizarClienteCommand)
        {
            try
            {
                atualizarClienteCommand.ClienteId = id;
                return Ok(await _mediator.Send(atualizarClienteCommand));
                _log.Info("Client Updated");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                _log.Error("Fail , Client don´t uptadeted");

            }
        }
        [HttpPost]
        public async Task<IActionResult> Adicionar(Cliente cliente)
        {
            try
            {

                return Ok(await _mediator.Send(cliente));
                _log.Info("Client Added");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                _log.Error("Fail , Client don´t Add");

            }
        }
        [HttpDelete]
        public async Task<IActionResult> Remover(Guid id)
        {
            try
            {
                return Ok(await _mediator.Send(new RemoverClienteCommand { ClienteId = id }));
                _log.Info("Client Removed");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                _log.Error("Fail , Client don´t Removed");

            }
        }
    }
}
