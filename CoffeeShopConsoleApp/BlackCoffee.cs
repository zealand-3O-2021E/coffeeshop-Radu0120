using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount):base(discount)
        {
            Name = "black coffee";
        }
        public override string Strenght()
        {
            return "Strong";
        }

        public override int price()
        {
            if (Discount <= 5)
                return base.price() - Discount;
            else throw new ArgumentException();
        }
    }
}
