using logpot.io.customers_management_app.entities.Service;
using System.ComponentModel.DataAnnotations.Schema;

namespace logpot.io.customers_management_app.entities.Restaurant
{
    public class RestaurantEntity : BaseEntity.BaseEntity, IRestaurantEntity
    {
        public RestaurantEntity() { }

        public RestaurantEntity(string name, RestaurantStatus status, IEnumerable<ServiceEntity> services)
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            Name = name;
            Status = status;
            Services = services;
        }

        public string Name { get; set; }
        public RestaurantStatus Status { get; set; }
        public IEnumerable<ServiceEntity> Services { get; set; }
    }
}
