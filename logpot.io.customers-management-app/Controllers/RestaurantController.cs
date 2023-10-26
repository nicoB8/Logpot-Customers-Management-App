using logpot.io.customers_management_app.business_logic.Restaurant;
using logpot.io.customers_management_app.entities.Restaurant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace logpot.io.customers_management_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private IRestaurantBL RestaurantBL { get; set; }

        public RestaurantController(IRestaurantBL restaurantBL)
        {
            RestaurantBL = restaurantBL;
        }

        [HttpGet]
        public async Task<RestaurantEntity> Get(string id)
        {
            var restaurant = await RestaurantBL.Get(id);

            return restaurant;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IEnumerable<RestaurantEntity>> GetAll()
        {
            var restaurants = RestaurantBL.GetAll();

            return restaurants;
        }
    }
}
