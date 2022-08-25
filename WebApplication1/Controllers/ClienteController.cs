using Mercado.Entidades.Models;
using Mercado.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mercado.Web.Controllers
{
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        [HttpGet]
        public IActionResult ObterTodos()
        {
            try
            {
                return Ok(_clienteService.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                return Ok(_clienteService.ObterPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        public void Atualizar(int id)
        {
            try
            {
                _clienteService.Atualizar(id);
            }
            catch (Exception ex)
            {
                BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public void Adicionar(Cliente cliente)
        {
            try
            {
                _clienteService.Adicionar(cliente);
            }
            catch (Exception ex)
            {
                BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        public void Remover(int id)
        {
            try
            {
                _clienteService.Remover(id);
            }
            catch (Exception ex)
            {
                BadRequest(ex.ToString());
            }
        }
    }
}
