namespace logpot.io.customers_management_app.entities.Service
{
    public abstract class ServiceEntity : IServiceEntity
    {
        public ServiceEntity(string name, double price, DateTime startDate, DateTime endDate)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
            StartDate = startDate;
            EndDate = endDate;
            IsActive = endDate > DateTime.Today;
        }

        public string Id { get; }
        public string Name { get; }
        public double Price { get; set; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public bool IsActive { get; }
    }
}
