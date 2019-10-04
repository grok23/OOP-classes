using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lunch meal1, meal2, meal3, meal4;
            meal1 = new Lunch();
            meal1.Entree = "slop";
            meal1.Side = "droppings";
            meal1.Drink = "sweat";

            meal2 = new Lunch("cabbage", "gruel", "vodka");
            meal3 = new Lunch("bruschetta", "fries", "beer");
            meal4 = new Lunch("calamari","spaghetti","red wine");

            DisplayMeals(meal1, meal2, meal4);
           
            DisplayMeals(meal1, meal2, meal3, meal4);

            DisplayMeals(meal4, meal3);
        }

        static void DisplayMeals(params Lunch[] meals)
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("{0,-12}{1,-12}{2,-12}", "Entree", "Side", "Drink");

            foreach (Lunch meal in meals)
            {
                Console.WriteLine("{0,-12}{1,-12}{2,-12}", meal.Entree, meal.Side, meal.Drink);
            }
            Console.WriteLine("\n");
        }
    }
}
