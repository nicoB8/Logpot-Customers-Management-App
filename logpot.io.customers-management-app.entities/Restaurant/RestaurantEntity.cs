using logpot.io.customers_management_app.entities.Service;

namespace logpot.io.customers_management_app.entities.Restaurant
{
    public class RestaurantEntity : IRestaurantEntity
    {
        public RestaurantEntity(string name, RestaurantStatus status, IEnumerable<IServiceEntity> services)
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            Name = name;
            Status = status;
            Services = services;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public RestaurantStatus Status { get; set; }
        public IEnumerable<IServiceEntity> Services { get; set; }
    }
}
