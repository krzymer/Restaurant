using System.Collections.Generic;
using System;

namespace RestaurantOrder.Model
{
    /// <summary>
    /// Klasa definiująca zamownie
    /// </summary>
    public class Order: IAdultInfo
    {
        public int Id { get; set; }
        //public List<byte> MenuItems { get; set; }
        public double Cost { get; set; }
        public string Comments { get; set; }
        public virtual List<Menu> MenuItems { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
