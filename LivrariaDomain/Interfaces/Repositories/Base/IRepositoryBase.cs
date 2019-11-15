using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LivrariaDomain.Interfaces.Repositories.Base
{
    public interface IRepositoryBase <TEntity, TId>
        where TEntity : class
        where TId: struct
    {
        IQueryable<TEntity> ListBy(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> ListAndOrderBy <TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> order, bool ascending = true, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity GetBy(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] includeProperties);

        bool Exist(Func<TEntity, bool> where);

        IQueryable<TEntity> ToList (params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> ToListAndOrderFor <TKey>(Expression<Func<TEntity, TKey>> order, bool ascending = true, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity GetById (TId id, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity ToAdd (TEntity entity);

        TEntity ToEdit (TEntity entity);

        void ToRemove (TEntity entity);

        IEnumerable<TEntity> AddList (IEnumerable<TEntity> entities);
    }
}
