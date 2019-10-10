using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister reg1 = new CashRegister();
            reg1.AddItem(4.99M);
            reg1.AddItem(9.99M);
            reg1.AddItem(3.50M);
            reg1.AddItem(99.98M);

            Console.WriteLine("Basket 1, "+ reg1);


            CashRegister reg2 = new CashRegister();
            reg2.AddItem(10.99M);
            reg2.AddItem(100.00M);
            reg2.AddItem(99.80M);
            reg2.AddItem(0.99M);
            reg2.AddItem(4.99M);

            Console.WriteLine("Basket 2, "+ reg2);
            

        }
    }
}
