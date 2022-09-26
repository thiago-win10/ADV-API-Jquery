//using Mercado.Entidades.Models;
//using Microsoft.AspNetCore.Mvc;
//using System;

//namespace Mercado.Web.Controllers
//{
//    public class ProdutoController : ControllerBase
//    {
//        //private readonly IProdutoService _produtoService;


//        //public ProdutoController(IProdutoService produtoService)
//        //{
//          //  _produtoService = produtoService;
//        //}
//        [HttpGet]
//        public IActionResult ObterTodos()
//        {
//            try
//            {
//                return Ok(_produtoService.ObterTodos());
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
//                return Ok(_produtoService.ObterPorId(id));
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
//                _produtoService.Atualizar(id);
//            }
//            catch (Exception ex)
//            {
//                BadRequest(ex.ToString());
//            }
//        }
//        [HttpPost]
//        public void Adicionar(Produto produto)
//        {
//            try
//            {
//                _produtoService.Adicionar(produto);
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
//                _produtoService.Remover(id);
//            }
//            catch (Exception ex)
//            {
//                BadRequest(ex.ToString());
//            }
//        }
//    }
//}
