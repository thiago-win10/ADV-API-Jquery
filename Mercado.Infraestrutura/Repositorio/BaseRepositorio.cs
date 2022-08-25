using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Context;
using Mercado.Infraestrutura.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Infraestrutura.Repositorio
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly MercadoContext MercadoContext;
        public BaseRepositorio(MercadoContext mercadocontexto)
        {
            MercadoContext = mercadocontexto;
        }
        public void Adicionar(TEntity entity)
        {
            MercadoContext.Set<TEntity>().Add(entity);
            MercadoContext.SaveChanges();
        }
        public void Atualizar(int id)
        {

            MercadoContext.Update(id);
            MercadoContext.SaveChanges();
        }
        public TEntity ObterPorId(int Id)
        {
            return MercadoContext.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> ObterTodos()

        {
            return MercadoContext.Set<TEntity>().ToList();
        }

        public void Remover(int id)
        {

            var obj = ObterPorId(id);
            MercadoContext.Remove(obj);
            MercadoContext.SaveChanges();

        }
        public void Dispose()
        {
            MercadoContext.Dispose();
        }
    }
}
