using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Flat_White : Coffee, IMilk
    {
        public Flat_White(int discount):base(discount)
        {
        }
        public int mlMilk()
        {
            return 300;
        }

        public override string Strenght()
        {
            return "Weak";
        }

        public override int price()
        {
            if (Discount <= 5)
                return base.price() - Discount;
            else throw new ArgumentException();
        }
    }
}
