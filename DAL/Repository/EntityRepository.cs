using DAL.DTO;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class EntityRepository<TContext, TEntity> : IRepository<TEntity> where TEntity : class
        where TContext : DbContext

    {
        private DbSet<TEntity> dbSet
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }

        private readonly TContext _context;
        public EntityRepository(TContext context)
        {
            _context = context;
        }

        public void Add(TEntity instance)
        {
            dbSet.Add(instance);
        }

        public void Update(TEntity instance)
        {
            var entry = _context.Entry(instance);
            if (entry.State == EntityState.Detached)
                dbSet.Attach(instance);
            entry.State = EntityState.Modified;
        }

        public void Delete(TEntity instance)
        {
            dbSet.Remove(instance);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.FirstOrDefault(predicate);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<List<T>> GetFromSql<T>(string command, params object[] parameters) where T : class
        {
            return await _context.Set<T>().FromSql<T>(command, parameters).ToListAsync();
        }

        public async Task<TEntity> GetWithIncludeAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = dbSet.AsQueryable();

            if (includes != null)
            {
                query = includes.Aggregate(
                    query,
                    (current, include) => current.Include(include));
            }

            var result = query.FirstOrDefaultAsync(predicate);
            return await result;
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbSet.AsQueryable();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public IQueryable<TEntity> GetAllWithInclude(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = dbSet.AsQueryable();

            if (includes != null)
            {
                query = includes.Aggregate(
                    query,
                    (current, include) => current.Include(include));
            }

            return query;
        }

        public async Task<List<TEntity>> GetAllWithIncludeAsync(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = dbSet.AsQueryable();

            if (includes != null)
            {
                query = includes.Aggregate(
                    query,
                    (current, include) => current.Include(include));
            }

            return await query.ToListAsync();
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public IQueryable<TEntity> FindWithInclude(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes)
        {
            var query = dbSet.AsQueryable();
            if (includes != null)
            {
                query = includes.Aggregate(
                    query,
                    (current, include) => current.Include(include));
            }
            return query.Where(predicate);
        }

        public virtual PaginatedList<TEntity> GetPaged(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy,
            int pageIndex = 1, int pageSize = 10,
            Expression<Func<TEntity, bool>> filter = null,
            IList<Expression<Func<TEntity, object>>> includedProperties = null)
        {
            var query = orderBy(dbSet);
            int totalCount = query.Count();
            var collection = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).AsNoTracking();
            return new PaginatedList<TEntity>(collection, pageIndex, pageSize, totalCount);
        }

        public int ExecSql(string command, params object[] parameters)
        {
            return _context.Database.ExecuteSqlCommand(command, parameters);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
