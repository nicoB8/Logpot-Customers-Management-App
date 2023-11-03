using logpot.io.customers_management_app.business_logic.BaseLogic;
using logpot.io.customers_management_app.dto.Restaurant;
using logpot.io.customers_management_app.entities.Restaurant;

namespace logpot.io.customers_management_app.business_logic.Restaurant
{
    public interface IRestaurantBL : IBaseLogic<RestaurantEntity, RestaurantDTO>{}
}
