using System.Data.Entity;

using RestaurantOrder.Model;

namespace RestaurantOrder.Data
{
    public class OrdersRepository: GenericRepository<Order>
    {
        public OrdersRepository(DbContext context)
            : base(context)
        {
        }

    }
}
