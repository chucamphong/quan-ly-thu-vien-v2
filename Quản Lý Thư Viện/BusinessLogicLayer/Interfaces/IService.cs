using System.Collections.Generic;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public interface IService<TEntity>
        where TEntity : class, IEntity
    {
        IEnumerable<TEntity> All();

        int Count();

        TEntity Find(int id);

        IEnumerable<TEntity> SearchByName(string name);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
