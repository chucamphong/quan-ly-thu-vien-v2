using System;
using System.Collections.Generic;
using System.Linq;
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

        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> filter);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Save();
    }
}
