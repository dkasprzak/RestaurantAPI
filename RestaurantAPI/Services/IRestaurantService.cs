using RestaurantAPI.Dto;
using System.Security.Claims;

namespace RestaurantAPI.Services
{
    public interface IRestaurantService
    {
        RestaurantDto GetById(int id);

        PageResult<RestaurantDto> GetAll(RestaurantQuery query);

        int Create(CreateRestaurantDto dto);

        void Delete(int id);

        void Update(int id, UpdateRestaurantDto dto);
    }
}
