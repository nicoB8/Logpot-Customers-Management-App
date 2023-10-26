namespace logpot.io.customers_management_app.entities.Service
{
    public class ManagedService : ServiceEntity
    {
        public ManagedService(double price, DateTime startDate, DateTime endDate, string userId, int hoursConsumed) : base("Managed Service", price, startDate, endDate)
        {
            UserId = userId;
            HoursConsumed = hoursConsumed;
        }

        public string UserId { get; set; }
        public int HoursConsumed { get; set; }
    }
}
