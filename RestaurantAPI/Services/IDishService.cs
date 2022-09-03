using RestaurantAPI.Dto;

namespace RestaurantAPI.Services
{
    public interface IDishService
    {
        int Create(int restaurantId, CreateDishDto dto);

        DishDto GetById(int restaurantId, int dishId);

        List<DishDto> GetAll(int restaurantId);

        void RemoveAll(int restaurantId);

        void RemoveDishById(int restaurantId, int dishId);
    }
}
