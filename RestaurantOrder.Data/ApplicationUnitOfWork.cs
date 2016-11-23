using System;

using RestaurantOrder.Model;

namespace RestaurantOrder.Data
{

    /// <summary>
    /// Klasa implementuje wzorzec UnitOfWork, udostępniając publiczne właściwości do zarządzania zmianami w bazie danych 
    /// </summary>
    public class ApplicationUnitOfWork: IDisposable
    {
        private DataContext _context = new DataContext();

        private IRepository<Menu> _menus = null;
        private IRepository<Order> _orders = null;

        public IRepository<Menu> Menus
        {
            get
            {
                if (this._menus == null)
                {
                    this._menus = new GenericRepository<Menu>(this._context);
                }

                return this._menus;
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                if (this._orders == null)
                {
                    this._orders = new GenericRepository<Order>(this._context);
                }

                return this._orders;
            }
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public void Dispose()
        {
            if(this._context != null)
            {
                this._context.Dispose();
            }
        }
        
    }
}
