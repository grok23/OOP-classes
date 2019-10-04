using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchDemo
{
    class Lunch
    {
        public string Entree { get; set; }
        public string Side { get; set; }
        public string Drink { get; set; }

        public Lunch()
        {

        }
        public Lunch(string starter, string side, string liquid)
        {
            Entree = starter;
            Side = side;
            Drink = liquid;
        }
        public override string ToString()
        {
            return "Starter " + Entree + " and a side of " + Side + " washed down with a " + Drink;
        }
    }
}
