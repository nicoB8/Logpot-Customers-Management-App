namespace logpot.io.customers_management_app.entities.BaseEntity
{
    public interface IBaseEntity
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
