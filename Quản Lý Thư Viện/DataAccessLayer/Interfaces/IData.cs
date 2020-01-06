using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataTransferObject;

namespace DataAccessLayer
{
    public interface IData<TEntity>
        where TEntity : class, IEntity
    {
        IEnumerable<TEntity> All();

        int Count();

        TEntity Find(int id);

        TEntity FindByName(string name);

        IEnumerable<TEntity> SearchBy(Expression<Func<TEntity, bool>> filter);

        IEnumerable<TEntity> SearchByName(string name);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Save();
    }
}
