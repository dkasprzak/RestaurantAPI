using Microsoft.AspNetCore.Authorization;

namespace RestaurantAPI.Authorizarion
{
    public class CreatedMultipleRestaurantsRequirement : IAuthorizationRequirement
    {
        public CreatedMultipleRestaurantsRequirement(int minimumRestaurantCreated)
        {
            MinimumRestaurantsCreated = minimumRestaurantCreated;
        }

        public int MinimumRestaurantsCreated { get;}
    }
}
