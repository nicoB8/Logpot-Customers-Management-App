using logpot.io.customers_management_app.entities.Restaurant;
using logpot.io.customers_management_app.entities.Service;

namespace logpot.io.customers_management_app.business_logic.Restaurant
{
    public class RestaurantBL : IRestaurantBL
    {
        public IEnumerable<RestaurantEntity> Restaurants { get; set; }
        public RestaurantBL()
        {
            var services = new List<IServiceEntity>
            {
                new ManagedService(50, DateTime.Now, DateTime.Now.AddDays(30), "a123", 0)
            };

            Restaurants = new List<RestaurantEntity>
            {
                new RestaurantEntity("Nico", RestaurantStatus.Potential, services)
            };
        }

        public RestaurantEntity Create(RestaurantEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<RestaurantEntity> Get(string id)
        {
            return Task.FromResult(Restaurants.First(r => r.Id == id));
        }

        public IEnumerable<RestaurantEntity> GetAll()
        {
            return Restaurants;
        }
    }
}
