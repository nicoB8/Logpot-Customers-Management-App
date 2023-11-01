namespace logpot.io.customers_management_app.entities.Service
{
    public class ManagedService : ServiceEntity
    {
        public ManagedService() { }

        public ManagedService(double price, DateTime startDate, DateTime endDate, string userId, int hoursConsumed, string description) : base("Managed Service", price, startDate, endDate)
        {
            UserId = userId;
            HoursConsumed = hoursConsumed;
            Description = description;
        }

        public string UserId { get; set; }
        public string Description { get; set; }
        public int HoursConsumed { get; set; }
    }
}
