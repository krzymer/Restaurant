using System;
using System.Data.Entity.ModelConfiguration;

using RestaurantOrder.Model;

namespace RestaurantOrder.Data.Configuration
{
    public class OrderConfiguration: EntityTypeConfiguration<Order>
    {

        /// <summary>
        /// Konfiguracja atrybutów zamównienia
        /// </summary>
        public OrderConfiguration()
        {
            this.Property(p => p.Cost).IsRequired().IsRequired();
            this.Property(p => p.Comments).IsOptional().HasMaxLength(500);
            this.Property(p => p.ModifiedOn).IsRequired().HasColumnType("datetime");
        }
    }
}
