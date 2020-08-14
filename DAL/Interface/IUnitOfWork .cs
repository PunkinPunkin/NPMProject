using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IDisposing : IDisposable
    {
        event EventHandler Disposing;
    }

    public abstract class Disposable : IDisposing
    {
        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Disposing?.Invoke(this, new EventArgs());
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public event EventHandler Disposing;
    }

    public interface IUnitOfWork : IDisposing
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        void Commit();
    }
}
