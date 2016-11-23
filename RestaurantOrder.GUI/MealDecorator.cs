using RestaurantOrder.Model;
using System;

namespace RestaurantOrder.GUI
{
    /// <summary>
    /// Klasa implementujaca klasę abstrakcyjną MealAbstract wykorzystywana do obliczania wartosci zamowienia, ustwiania opisu. Wzorzec dekorator.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class MealDecorator<TEntity> : MealAbstract where TEntity : IMenuEntity
    {
        private MealAbstract _mealAbstract;
        private TEntity _menuItem;

        public MealDecorator(MealAbstract mealAbstract, TEntity menuItem) 
        {
            this._mealAbstract = mealAbstract;
            this._menuItem = menuItem;
        }

        public override double CalculateCost()
        {
            return this._mealAbstract.CalculateCost() + this._menuItem.Price;
        }

        public override string GetOrderDescription()
        {
            return string.Format("{0} ID:{1} - {2}, {3:C2} {4}", 
                this._mealAbstract.GetOrderDescription(), 
                this._menuItem.Id, 
                this._menuItem.Name, 
                this._menuItem.Price, 
                Environment.NewLine);
        }
    }
}
