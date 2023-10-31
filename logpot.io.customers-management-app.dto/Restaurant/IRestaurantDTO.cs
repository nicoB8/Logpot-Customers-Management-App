using logpot.io.customers_management_app.dto.BaseDTO;

namespace logpot.io.customers_management_app.dto.Restaurant
{
    public interface IRestaurantDTO : IBaseDTO
    {
        string Name { get; set; }
    }
}
