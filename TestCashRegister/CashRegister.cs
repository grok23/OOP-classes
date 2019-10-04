using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCashRegister
{
    public class CashRegister
    {
        public int ItemCount { get; private set; }

        public decimal Total { get; private set; }

        public void AddItem(decimal price)
        {
            Total += price;
            ItemCount++;
        }

        public override string ToString()   
        {
            return "Number of Items in basket: " + ItemCount + ". Cost = " + Total;
        }
    }
}