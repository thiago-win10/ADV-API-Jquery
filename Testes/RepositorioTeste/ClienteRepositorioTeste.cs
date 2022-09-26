using AutoMapper;
using Mercado.Entidades.Models;
using Mercado.Entidades.ViewModels;
using Mercado.Infraestrutura.Context;
using Mercado.Infraestrutura.Interface;
using Mercado.Infraestrutura.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Testes.RepositorioTeste
{
    public class ClienteRepositorioTeste
    {
        [TestMethod]
        public void CriarClienteSalvaOContext()
        {
            var mockSet = new Mock<DbSet<Cliente>>();

            var mockContext = new Mock<MercadoContext>();
            mockContext.Setup(m => m.Clientes).Returns(mockSet.Object);

            var repositorio = new ClienteRepositorio(mockContext.Object);
            repositorio.Atualizar(new Cliente() { NomeCompleto = "Livro de teste" });

            var cliente = new Cliente();


            var customerRepositoryMock = new Mock<IClienteRepositorio>();

            var mapperMock = new Mock<IMapper>();
            mapperMock.Setup(x => x.Map<ClienteViewModel>(cliente)).Returns(new ClienteViewModel
            {
                ClienteId = cliente.ClienteId,
                NomeCompleto = cliente.NomeCompleto,
                Email = cliente.Email,
                DataNascimento = cliente.DataNascimento,
            });


            mockSet.Verify(m => m.Add(It.IsAny<Cliente>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

            Assert.IsNotNull(repositorio);
        }
        public void AdicionarClienteContext()
        {
            var mockSet = new Mock<DbSet<Cliente>>();

            var id = Guid.NewGuid();

            var mockContext = new Mock<MercadoContext>();
            mockContext.Setup(m => m.Clientes).Returns(mockSet.Object);

            var repositorio = new ClienteRepositorio(mockContext.Object);
            repositorio.Adicionar(new Cliente() { NomeCompleto = "Livro A", Cpf = "42472501822"});
            
            mockSet.Verify(m => m.Add(It.IsAny<Cliente>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

            Assert.IsNotNull(repositorio);

        }

    }
}
