using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Context;
using Mercado.Infraestrutura.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            repositorio.Atualizar(new Cliente() { NomeCompleto = "Livro de teste", Status = true });

            mockSet.Verify(m => m.Add(It.IsAny<Cliente>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

            Assert.IsNotNull(repositorio);
        }
        public void AdicionarClienteContext()
        {
            var mockSet = new Mock<DbSet<Cliente>>();

            var mockContext = new Mock<MercadoContext>();
            mockContext.Setup(m => m.Clientes).Returns(mockSet.Object);

            var repositorio = new ClienteRepositorio(mockContext.Object);
            repositorio.Adicionar(new Cliente() { NomeCompleto = "Livro A", Status = true , Cpf = "42472501822"});

            mockSet.Verify(m => m.Add(It.IsAny<Cliente>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

            Assert.IsNotNull(repositorio);

        }

    }
}
