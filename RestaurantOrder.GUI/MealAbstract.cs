
namespace RestaurantOrder.GUI
{

    /// <summary>
    /// Klasa abstrakcyjna wykorzystywana do obliczania wartosci zamowienia, ustwiania opisu. Wzorzec dekorator.
    /// </summary>
    public abstract class MealAbstract
    {
        public abstract double CalculateCost();
        public abstract string GetOrderDescription();
    }
}
