using logpot.io.customers_management_app.entities.BaseEntity;
using Microsoft.EntityFrameworkCore;

namespace logpot.io.customers_management.repositories.BaseRepository
{
    public abstract class BaseRepository<Entity> : IBaseRepository<Entity>
        where Entity : BaseEntity
    {
        internal AppDBContext context;
        internal DbSet<Entity> dbSet;

        public BaseRepository(AppDBContext context)
        {
            this.context = context;
            dbSet = context.Set<Entity>();
        }

        public virtual Entity Create(Entity entity)
        {
            var e = dbSet.Add(entity).Entity;
            context.SaveChanges();
            return e;
        }

        public virtual void Delete(string Id)
        {
            var entityToDelete = dbSet.Find(Id);

            if (entityToDelete != null)
            {
                Delete(entityToDelete);
            }
        }

        public virtual void Delete(Entity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public virtual Entity Get(string Id)
        {
            return dbSet.Find(Id);
        }

        public virtual List<Entity> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual void Update(Entity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
