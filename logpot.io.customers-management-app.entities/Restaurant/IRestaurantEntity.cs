using logpot.io.customers_management_app.entities.BaseEntity;
using logpot.io.customers_management_app.entities.Service;

namespace logpot.io.customers_management_app.entities.Restaurant
{
    public interface IRestaurantEntity : IBaseEntity
    {
        string Name { get; set; }
        RestaurantStatus Status { get; set; }
        IEnumerable<ServiceEntity> Services { get; set; }
    }
}
