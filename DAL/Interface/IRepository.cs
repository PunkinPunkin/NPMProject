using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        void Add(TEntity instance);

        void Update(TEntity instance);

        void Delete(TEntity instance);

        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);

        Task<List<T>> GetFromSql<T>(string command, params object[] parameters) where T : class;

        Task<TEntity> GetWithIncludeAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);

        IQueryable<TEntity> GetAll();

        Task<List<TEntity>> GetAllAsync();

        IQueryable<TEntity> GetAllWithInclude(params Expression<Func<TEntity, object>>[] includes);

        Task<List<TEntity>> GetAllWithIncludeAsync(params Expression<Func<TEntity, object>>[] includes);

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> FindWithInclude(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);

        PaginatedList<TEntity> GetPaged(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, int pageIndex, int pageSize, Expression<Func<TEntity, bool>> filter = null, IList<Expression<Func<TEntity, object>>> includedProperties = null);

        int ExecSql(string command, params object[] parameters);
    }
}
