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
        protected readonly MercadoContext _mercadoContext;
        public BaseRepositorio(MercadoContext mercadocontexto)
        {
            _mercadoContext = mercadocontexto;
        }
        public async Task<TEntity> Adicionar(TEntity entity)
        {
            _mercadoContext.Set<TEntity>().Add(entity);
            _mercadoContext.SaveChanges();
            return entity;
        }
        public TEntity ObterPorId(Guid Id)
        {
            return _mercadoContext.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> ObterTodos()

        {
            return _mercadoContext.Set<TEntity>().ToList();
        }

        public void Dispose()
        {
            _mercadoContext.Dispose();
        }

        public async Task<TEntity> Atualizar(TEntity entity)
        {
            _mercadoContext.Set<TEntity>().Update(entity);
            _mercadoContext.SaveChanges();
            return entity;
        }

        bool IBaseRepositorio<TEntity>.Remover(Guid id)
        {
            var obj = ObterPorId(id);
            if (obj != null)
            {
                _mercadoContext.Remove(id);
                _mercadoContext.SaveChanges();
            }
            return false;
        }
    }
}
