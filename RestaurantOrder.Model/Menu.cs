using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RestaurantOrder.Model
{

    /// <summary>
    /// Klasa definiujaca menu
    /// </summary>
    public class Menu: IAdultInfo, IMenuEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public TypeOfMeal? Type { get; set; } 
        public bool IsAddition { get; set; }
        public TypeOfMeal? AdditionTo { get; set; }
        public TypeOfMealAdditions? AdditionType { get; set; }
        public DateTime ModifiedOn { get; set; }
    }

    /// <summary>
    /// Enum dań głównych
    /// </summary>
    public enum TypeOfMeal: int
    {
        [Description("Pizza")]
        Pizza = 1,
        [Description("Dania główne")]
        MainCourse = 2,     
        [Description("Zupa")]
        Soup = 3,
        [Description("Napój")]
        Drink = 4
    }


    /// <summary>
    /// Enum dodatków
    /// </summary>
    public enum TypeOfMealAdditions: int
    {
        [Description("Dodatki do pizzy")]
        PizzaTopping = 1,
        [Description("Dodatki do dań głównych")]
        AdditionsMainCourse = 2
    }
}
