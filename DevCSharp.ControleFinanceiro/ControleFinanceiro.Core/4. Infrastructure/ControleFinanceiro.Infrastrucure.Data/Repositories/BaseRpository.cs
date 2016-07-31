using System;
using System.Collections.Generic;
using ControleFinanceiro.Domain.Interfaces;
using System.Linq;
using System.Data.Entity;

namespace ControleFinanceiro.Infrastrucure.Data.Repositories
{
    public class BaseRpository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected ControleFinanceiroContexto Contexto = new ControleFinanceiroContexto();

        public void Adicionar(TEntity entity)
        {
            Contexto.Set<TEntity>().Add(entity);
            Contexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            Contexto.Entry(entity).State = EntityState.Modified;
            Contexto.SaveChanges();
        }

        public void Deletar(TEntity entity)
        {
            Contexto.Set<TEntity>().Remove(entity);
            Contexto.SaveChanges();
        }


        public TEntity ObterPorId(int entityId)
        {
            return Contexto.Set<TEntity>().Find(entityId);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return Contexto.Set<TEntity>().ToList();
        }

        #region Dispose
        protected bool disposed;

        ~BaseRpository()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (!Equals(Contexto, null))
                Contexto.Dispose();

            disposed = true;
        }
        #endregion
    }
}
