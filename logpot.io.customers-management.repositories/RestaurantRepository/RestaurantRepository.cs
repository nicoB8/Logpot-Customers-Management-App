using logpot.io.customers_management.repositories.BaseRepository;
using logpot.io.customers_management_app.entities.Restaurant;

namespace logpot.io.customers_management.repositories.RestaurantRepository
{
    public class RestaurantRepository : BaseRepository<RestaurantEntity>, IRestaurantRepository
    {
        public RestaurantRepository(AppDBContext context) : base(context)
        {
        }
    }
}
