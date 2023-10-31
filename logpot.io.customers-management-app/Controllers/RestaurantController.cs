using AutoMapper;
using logpot.io.customers_management_app.business_logic.Restaurant;
using logpot.io.customers_management_app.dto.Restaurant;
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
        private readonly IMapper _mapper;

        public RestaurantController(IRestaurantBL restaurantBL, IMapper mapper)
        {
            RestaurantBL = restaurantBL;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<RestaurantEntity> Get(string id)
        {
            var restaurant = await RestaurantBL.Get(id);

            return restaurant;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IEnumerable<RestaurantDTO>> GetAll()
        {
            var restaurants = RestaurantBL.GetAll();

            return _mapper.Map<IEnumerable<RestaurantDTO>>(restaurants);
        }
    }
}
