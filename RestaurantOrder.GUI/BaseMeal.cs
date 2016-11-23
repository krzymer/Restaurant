
namespace RestaurantOrder.GUI
{

    /// <summary>
    /// Bazwa klasa obiektu zamowienia. Wzorzec dekorator.
    /// </summary>
    public class BaseMeal: MealAbstract
    {
        public override double CalculateCost()
        {
            return 0;
        }

        public override string GetOrderDescription()
        {
            return string.Empty;
        }



    }
}
