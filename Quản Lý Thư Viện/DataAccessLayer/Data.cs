using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataTransferObject;

namespace DataAccessLayer
{
    public abstract class Data<TEntity> : IData<TEntity>
        where TEntity : class, IEntity
    {
        public Data()
        {
            this.Entity = this.Context.Set<TEntity>();
            this.Context.Database.Log = Console.WriteLine;
        }

        protected LibraryManagementSystemContext Context { get; } = LibraryManagementSystemContext.Instance;

        protected DbSet<TEntity> Entity { get; }

        public virtual IEnumerable<TEntity> All()
        {
            return this.Entity.OrderBy(entity => entity.Id);
        }

        public int Count()
        {
            return this.Entity.AsNoTracking().Count();
        }

        public virtual void Delete(TEntity entity)
        {
            TEntity localEntity = this.Entity.Local.FirstOrDefault(e => e.Id == entity.Id);

            if (localEntity != null)
            {
                this.Context.Entry(localEntity).State = EntityState.Detached;
            }

            if (this.Context.Entry(entity).State == EntityState.Detached)
            {
                this.Entity.Attach(entity);
            }

            this.Entity.Remove(entity);
        }

        public virtual TEntity Find(int id)
        {
            return this.Entity.FirstOrDefault(entity => entity.Id == id);
        }

        public virtual TEntity FindByName(string name)
        {
            return this.Entity.FirstOrDefault(entity => entity.Name == name);
        }

        public virtual IEnumerable<TEntity> SearchBy(Expression<Func<TEntity, bool>> filter)
        {
            return this.Entity.OrderBy(entity => entity.Id).Where(filter);
        }

        public virtual IEnumerable<TEntity> SearchByName(string name)
        {
            return this.SearchBy(entity => entity.Name.Contains(name));
        }

        public virtual void Insert(TEntity entity)
        {
            this.Entity.Add(entity);
        }

        public virtual void Save()
        {
            this.Context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            TEntity localEntity = this.Entity.Local.FirstOrDefault(e => e.Id == entity.Id);

            if (localEntity != null)
            {
                this.Context.Entry(localEntity).State = EntityState.Detached;
            }

            this.Context.Entry(entity).State = EntityState.Modified;
        }
    }
}
