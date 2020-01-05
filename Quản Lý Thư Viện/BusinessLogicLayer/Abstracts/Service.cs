using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public abstract class Service<TEntity> : IService<TEntity>
        where TEntity : class, IEntity
    {
        public Service()
        {
            this.Data = this.Entity();
        }

        protected IData<TEntity> Data { get; }

        public virtual async Task<IEnumerable<TEntity>> All()
        {
            return await Task.Run(() => this.Data.All());
        }

        public virtual int Count()
        {
            return this.Data.Count();
        }

        public virtual void Delete(TEntity entity)
        {
            this.Data.Delete(entity);
            this.Data.Save();
        }

        public TEntity Find(int id)
        {
            return this.Data.Find(id);
        }

        public TEntity FindByName(string name)
        {
            return this.Data.FindByName(name);
        }

        public virtual IEnumerable<TEntity> SearchByName(string name)
        {
            return this.Data.SearchByName(name);
        }

        public virtual void Insert(TEntity entity)
        {
            this.Data.Insert(entity);
            this.Data.Save();
        }

        public virtual void Update(TEntity entity)
        {
            this.Data.Update(entity);
            this.Data.Save();
        }

        protected abstract IData<TEntity> Entity();
    }
}
