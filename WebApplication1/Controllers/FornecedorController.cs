//using Mercado.Entidades.Models;
//using Microsoft.AspNetCore.Mvc;
//using System;

//namespace Mercado.Web.Controllers
//{
//    public class FornecedorController : ControllerBase
//    {
//        //private readonly IFornecedorService _fornecedorService;


//        //public FornecedorController(IFornecedorService fornecedorService)
//        //{
//          //  _fornecedorService = fornecedorService;
//        //}
//        [HttpGet]
//        public IActionResult ObterTodos()
//        {
//            try
//            {
//                return Ok(_fornecedorService.ObterTodos());
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.ToString());
//            }
//        }
//        [HttpGet]
//        public IActionResult ObterPorId(int id)
//        {
//            try
//            {
//                return Ok(_fornecedorService.ObterPorId(id));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.ToString());
//            }
//        }
//        [HttpPut]
//        public void Atualizar(int id)
//        {
//            try
//            {
//                _fornecedorService.Atualizar(id);
//            }
//            catch (Exception ex)
//            {
//                BadRequest(ex.ToString());
//            }
//        }
//        [HttpPost]
//        public void Adicionar(Fornecedor fornecedor)
//        {
//            try
//            {
//                _fornecedorService.Adicionar(fornecedor);
//            }
//            catch (Exception ex)
//            {
//                BadRequest(ex.ToString());
//            }
//        }
//        [HttpDelete]
//        public void Remover(int id)
//        {
//            try
//            {
//                _fornecedorService.Remover(id);
//            }
//            catch (Exception ex)
//            {
//                BadRequest(ex.ToString());
//            }
//        }
//    }
//}

