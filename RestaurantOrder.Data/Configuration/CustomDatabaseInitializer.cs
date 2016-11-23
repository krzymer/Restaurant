using System;
using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;

using RestaurantOrder.Data;
using RestaurantOrder.Model;


namespace RestaurantOrder.Data.Configuration
{
    public class CustomDatabaseInitializer : CreateDatabaseIfNotExists<DataContext> //DropCreateDatabaseAlways<DataContext>  
    {

        /// <summary>
        /// Metoda uzupełnia danymi pozycje z menu
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DataContext context)
        {
            List<Menu> menus = new List<Menu>() 
            {
                new Menu { Name = "Mergheritta", Price = 20, Type = TypeOfMeal.Pizza, IsAddition = false, AdditionType = null, AdditionTo = null},
                new Menu { Name = "Vegetariana", Price = 22, Type = TypeOfMeal.Pizza, IsAddition = false, AdditionType = null, AdditionTo = null },
                new Menu { Name = "Tosca", Price = 25, Type = TypeOfMeal.Pizza, IsAddition = false, AdditionType = null, AdditionTo = null },
                new Menu { Name = "Venecia", Price = 25, Type = TypeOfMeal.Pizza, IsAddition = false, AdditionType = null, AdditionTo = null },
                new Menu { Name = "Dodatkowy ser", Price = 2, Type = null, IsAddition = true, AdditionType =  TypeOfMealAdditions.PizzaTopping, AdditionTo = TypeOfMeal.Pizza },               
                new Menu { Name = "Szynka", Price = 2, Type = null, IsAddition = true, AdditionType =  TypeOfMealAdditions.PizzaTopping, AdditionTo = TypeOfMeal.Pizza },
                new Menu { Name = "Salami", Price = 2, Type = null, IsAddition = true, AdditionType =  TypeOfMealAdditions.PizzaTopping, AdditionTo = TypeOfMeal.Pizza },
                new Menu { Name = "Pieczarki", Price = 2, Type = null, IsAddition = true, AdditionType =  TypeOfMealAdditions.PizzaTopping, AdditionTo = TypeOfMeal.Pizza },
                new Menu { Name = "Schabowy z frytkami/ryżem/ziemniakami", Price = 30, Type = TypeOfMeal.MainCourse, IsAddition = false, AdditionType = null,  AdditionTo = null},
                new Menu { Name = "Ryba z frytkami", Price = 28, Type = TypeOfMeal.MainCourse, IsAddition = false, AdditionType = null,  AdditionTo = null },
                new Menu { Name = "Placek po węgiersku", Price = 27, Type = TypeOfMeal.MainCourse, IsAddition = false,AdditionType = null,  AdditionTo = null },
                new Menu { Name = "Bar sałatkowy", Price = 5, Type = null, IsAddition = true, AdditionType = TypeOfMealAdditions.AdditionsMainCourse, AdditionTo = TypeOfMeal.MainCourse },
                new Menu { Name = "Zestaw sosów", Price = 6, Type = null, IsAddition = true, AdditionType = TypeOfMealAdditions.AdditionsMainCourse, AdditionTo = TypeOfMeal.MainCourse },
                new Menu { Name = "Pomidorowa", Price = 12, Type = TypeOfMeal.Soup, IsAddition = false, AdditionType = null, AdditionTo = null },
                new Menu { Name = "Rosół", Price = 10, Type = TypeOfMeal.Soup, IsAddition = false, AdditionType = null, AdditionTo = null },
                new Menu { Name = "Kawa", Price = 5, Type = TypeOfMeal.Drink, IsAddition = false, AdditionType = null, AdditionTo = null },
                new Menu { Name = "Herbata", Price = 5, Type = TypeOfMeal.Drink, IsAddition = false, AdditionType = null, AdditionTo = null },
                new Menu { Name = "Cola", Price = 5, Type = TypeOfMeal.Drink, IsAddition = false, AdditionType = null, AdditionTo = null }
            };

            context.Menus.AddRange(menus);


            base.Seed(context);
        }
    }
}
