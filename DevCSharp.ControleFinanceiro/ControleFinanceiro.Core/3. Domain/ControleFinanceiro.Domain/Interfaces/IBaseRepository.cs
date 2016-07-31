using System;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Deletar(TEntity entity);
        TEntity ObterPorId(int entityId);
        IEnumerable<TEntity> ObterTodos();      
    }
}
