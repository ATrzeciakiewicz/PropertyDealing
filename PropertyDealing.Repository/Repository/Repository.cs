using PropertyDealing.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;


namespace PropertyDealing.Repository.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext Context { get; set; }
        protected DbSet<TEntity> DbSet { get; set; }

        public Repository(DbContext context)
        {
            this.Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> filter)
        {
            return DbSet.Where(filter).ToList();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public void Remove(int id)
        {
            TEntity entity = DbSet.Find(id);
            DbSet.Remove(entity);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }
    }
}
