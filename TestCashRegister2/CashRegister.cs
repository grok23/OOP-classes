using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCashRegister2
{
    public class CashRegister
    {
        public static int TotalItemCount { get; set; }
        public static decimal TotalSales { get; set; }
        public int ItemCount { get; private set; }

        public decimal Total { get; private set; }

        public void AddItem(decimal price)
        {
            Total += price;
            ItemCount++;
            TotalItemCount++;       //increments the static TotalItemCount
            TotalSales += price;    //adds the price to the static TotalSales
        }

        public override string ToString()
        {
            return "Number of Items in basket: " + ItemCount + ". Cost = " + Total;
        }
    }
}