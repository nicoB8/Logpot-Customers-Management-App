namespace logpot.io.customers_management_app.entities.BaseEntity
{
    public abstract class BaseEntity : IBaseEntity
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
