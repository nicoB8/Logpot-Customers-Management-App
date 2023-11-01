using logpot.io.customers_management_app.entities.BaseEntity;

namespace logpot.io.customers_management.repositories.BaseRepository
{
    public interface IBaseRepository<Entity>
        where Entity : IBaseEntity
    {
        public Entity Create(Entity entity);
        public void Update(Entity entity);
        public void Delete(string Id);
        public void Delete(Entity entity);
        public Entity Get(string Id);
        public List<Entity> GetAll();
    }
}
