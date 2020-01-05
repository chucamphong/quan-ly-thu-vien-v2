using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public interface IService<TEntity>
        where TEntity : class, IEntity
    {
        Task<IEnumerable<TEntity>> All();

        int Count();

        TEntity Find(int id);

        IEnumerable<TEntity> SearchByName(string name);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
