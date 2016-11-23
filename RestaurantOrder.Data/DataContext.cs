using System;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.Entity;

using RestaurantOrder.Model;
using RestaurantOrder.Data.Configuration;

namespace RestaurantOrder.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }

        public static string ConnectionStringName
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionStringName"] != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionStringName"].ToString();
                }

                return "DefaultConnection";
            }
        }

        public DataContext() : base(nameOrConnectionString: DataContext.ConnectionStringName)
        {

        }

        static DataContext()
        {
            Database.SetInitializer(new CustomDatabaseInitializer());
        }


        /// <summary>
        /// Ustawienie konfiguracji definicji atrybutów tabel bazy danych na podstawie klas, CodeFirst
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MenuConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());

            //base.OnModelCreating(modelBuilder);
        }


        /// <summary>
        /// Metoda uruchamiana za każdym razem podczas zapisu danych. Uzupełnia atrybut daty we wszystkich obiektach, których klasa implementuje interfejs IAdultInfo
        /// </summary>
        private void ApplayRoles()
        {
            foreach (var entity in ChangeTracker.Entries()
                .Where(e => e.Entity is IAdultInfo &&
                e.State == EntityState.Added || e.State == EntityState.Modified))
            {
                IAdultInfo e = (IAdultInfo)entity.Entity;

                e.ModifiedOn = DateTime.Now;
            }
        }


        /// <summary>
        /// Zapis zmian do bazy danych
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            this.ApplayRoles();

            return base.SaveChanges();
        }
    }
}
