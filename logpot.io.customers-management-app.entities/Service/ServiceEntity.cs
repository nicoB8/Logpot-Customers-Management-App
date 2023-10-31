namespace logpot.io.customers_management_app.entities.Service
{
    public abstract class ServiceEntity : BaseEntity.BaseEntity, IServiceEntity
    {
        public ServiceEntity(string name, double price, DateTime startDate, DateTime endDate)
        {
            Id = Guid.NewGuid().ToString();
            base.CreatedAt = DateTime.Now;
            Name = name;
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
            IsActive = endDate > DateTime.Today;
        }

        public string Name { get; }
        public double Price { get; set; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public bool IsActive { get; }
    }
}
