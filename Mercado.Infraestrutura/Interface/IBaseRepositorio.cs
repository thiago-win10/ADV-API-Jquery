using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mercado.Infraestrutura.Interface
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> Adicionar(TEntity entity);

        TEntity ObterPorId(Guid id);

        IEnumerable<TEntity> ObterTodos();

        Task<TEntity> Atualizar(TEntity entity);

        bool Remover(Guid id);
    }
}