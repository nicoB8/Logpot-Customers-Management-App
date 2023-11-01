using logpot.io.customers_management_app.entities.BaseEntity;
using logpot.io.customers_management_app.entities.Restaurant;

namespace logpot.io.customers_management_app.entities.Service
{
    public interface IServiceEntity : IBaseEntity
    {
        string Name { get; }
        double Price { get; set; }
        bool IsActive { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        string RestaurantId { get; set; }
        RestaurantEntity Restaurant { get; set; }
    }
}
