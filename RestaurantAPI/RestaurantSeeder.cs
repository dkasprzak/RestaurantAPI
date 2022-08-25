using RestaurantAPI.Entities;

namespace RestaurantAPI.Seed
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbContext;

        public RestaurantSeeder(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "KFC",
                    Category = "Fast Food",
                    Description = "KFC (Kentucky Fried Chicken) is an American fast food restaurant chain headquartered in Louisville, Kentucky, that specializes in fried chicken.",
                    ContactEmail = "contact@kfc.com",
                    ContactNumber = "123456789",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Nashville Hot Chicken",
                            Price = 10.3M,
                            Description = "Nashville Hot Chicken"
                        },

                        new Dish()
                        {
                            Name = "Chicken Nuggets",
                            Price = 5.3M,
                            Description = "Chicken Nuggets"
                        },
                    },
                    Adress = new Adress()
                    {
                        City = "Kraków",
                        Street = "Długa 5",
                        PostalCode = "30-001",
                    }
                },

                new Restaurant()
                {
                    Name = "McDonald",
                    Category = "Fast Food",
                    Description = "McDonald's Corporation is an American-based multinational fast food chain, founded in 1940 as a restaurant operated by Richard and Maurice McDonald, in San Bernardino, California, United States.",
                    ContactEmail = "contact@mcd.com",
                    ContactNumber = "987654321",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Hamburger",
                            Price = 5.5M,
                            Description = "Hamburger"
                        },

                        new Dish()
                        {
                            Name = "Chips",
                            Price = 2.5M,
                            Description = "Chips"
                        },
                    },
                    Adress = new Adress()
                    {
                        City = "Kraków",
                        Street = "Szewska 5",
                        PostalCode = "30-002"
                    }
                }
            };

            return restaurants;
        }
    }
}
