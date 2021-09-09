using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, IMilk
    {
        public Latte(int discount):base(discount)
        {
            Name = "latte";
        }
        public int mlMilk()
        {
            return 200;
        }

        public override int price()
        {
            if (Discount <= 5)
            {
                return 40 - Discount;
            }
            else throw new ArgumentException();
        }
        public override string Strenght()
        {
            return "Weak";
        }
    }
}
