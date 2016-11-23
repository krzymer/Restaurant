using System;
using System.Data.Entity.ModelConfiguration;
using RestaurantOrder.Model;

namespace RestaurantOrder.Data.Configuration
{
    public class MenuConfiguration: EntityTypeConfiguration<Menu>
    {

        /// <summary>
        /// Konfiguracja atrybutów menu
        /// </summary>
        public MenuConfiguration()
        {
            this.Property(p => p.Name).IsRequired().HasMaxLength(150);
            this.Property(p => p.Price).IsRequired();
            this.Property(p => p.Type).IsOptional();
            this.Property(p => p.IsAddition).IsRequired();
            this.Property(p => p.AdditionType).IsOptional();
            this.Property(p => p.AdditionTo).IsOptional();
            this.Property(p => p.ModifiedOn).IsOptional().HasColumnType("datetime");
        }
    }
}
