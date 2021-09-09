using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado : Coffee, IMilk
    {
        public Cortado(int discount):base(discount)
        {
            Name = "cortado";
        }
        public int mlMilk()
        {
            return 40;
        }

        public override int price()
        {
            if (Discount <= 5)
            {
                return 25 - Discount;
            }
            else throw new ArgumentException();
        }

        public override string Strenght()
        {
            return "Medium";
        }
    }
}
