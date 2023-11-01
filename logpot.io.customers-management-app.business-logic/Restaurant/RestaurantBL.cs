using logpot.io.customers_management.repositories.RestaurantRepository;
using logpot.io.customers_management_app.dto.Restaurant;
using logpot.io.customers_management_app.entities.Restaurant;
using logpot.io.customers_management_app.entities.Service;

namespace logpot.io.customers_management_app.business_logic.Restaurant
{
    public class RestaurantBL : IRestaurantBL
    {
        public IEnumerable<RestaurantEntity> Restaurants { get; set; }
        private readonly IRestaurantRepository _restaurantRepository;
        public RestaurantBL(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public RestaurantEntity Create(RestaurantDTO entity)
        {
            var restaurant = new RestaurantEntity(entity.Name, RestaurantStatus.Potential);
            return _restaurantRepository.Create(restaurant);
        }

        public Task<RestaurantEntity> Get(string id)
        {
            return Task.FromResult(_restaurantRepository.Get(id));
        }

        public IEnumerable<RestaurantEntity> GetAll()
        {
            return _restaurantRepository.GetAll();
        }
    }
}
