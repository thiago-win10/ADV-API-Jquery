using Mercado.Entidades.Models;
using Mercado.Infraestrutura.Interface;
using Mercado.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Service.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        public readonly IBaseRepositorio<TEntity> _db;

        public BaseService(IBaseRepositorio<TEntity> db)
        {
            _db = db;
        }
        public void Adicionar(TEntity entity)
        {
            _db.Adicionar(entity);
        }

        public void Atualizar(int id)
        {
            _db.Atualizar(id);

        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return _db.ObterPorId(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _db.ObterTodos();
        }

        public void Remover(int id)
        {
            _db.Remover(id);
        }
    }
}
