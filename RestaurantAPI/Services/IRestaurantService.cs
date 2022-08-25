using RestaurantAPI.Dto;

namespace RestaurantAPI.Services
{
    public interface IRestaurantService
    {
        RestaurantDto GetById(int id);

        IEnumerable<RestaurantDto> GetAll();

        int Create(CreateRestaurantDto dto);

        bool Delete(int id);

        bool Update(int id, UpdateRestaurantDto dto);
    }
}
