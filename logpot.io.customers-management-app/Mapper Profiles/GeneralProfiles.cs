using AutoMapper;
using logpot.io.customers_management_app.dto.Restaurant;
using logpot.io.customers_management_app.entities.Restaurant;

namespace logpot.io.customers_management_app.Mapper_Profiles
{
    public class GeneralProfiles : Profile
    {
        public GeneralProfiles()
        {
            CreateMap<RestaurantEntity, RestaurantDTO>();
            CreateMap<RestaurantDTO, RestaurantEntity>();
        }
    }
}
