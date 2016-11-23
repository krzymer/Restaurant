using System.Data.Entity;

using RestaurantOrder.Model;

namespace RestaurantOrder.Data
{
    public class MenusRepository : GenericRepository<Menu>
    {
        public MenusRepository(DbContext context)
            : base(context)
        {
        }
    }
}
