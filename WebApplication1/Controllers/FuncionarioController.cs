using Mercado.Entidades.Models;
using Mercado.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mercado.Web.Controllers
{
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioService _funcionarioService;


        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }
        [HttpGet]
        public IActionResult ObterTodos()
        {
            try
            {
                return Ok(_funcionarioService.ObterTodos());
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
                return Ok(_funcionarioService.ObterPorId(id));
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
                _funcionarioService.Atualizar(id);
            }
            catch (Exception ex)
            {
                BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public void Adicionar(Funcionario funcionario)
        {
            try
            {
                _funcionarioService.Adicionar(funcionario);
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
                _funcionarioService.Remover(id);
            }
            catch (Exception ex)
            {
                BadRequest(ex.ToString());
            }
        }
    }
}

