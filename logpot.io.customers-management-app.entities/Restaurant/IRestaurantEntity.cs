using logpot.io.customers_management_app.entities.Service;

namespace logpot.io.customers_management_app.entities.Restaurant
{
    public interface IRestaurantEntity
    {
        string Id { get; set; }
        string Name { get; set; }
        DateTime CreatedAt { get; set; }
        RestaurantStatus Status { get; set; }
        IEnumerable<IServiceEntity> Services { get; set; }
    }
}
