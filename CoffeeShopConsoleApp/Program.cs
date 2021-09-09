using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new Latte(2),
                new Cortado(5),
                new BlackCoffee(3)

            };
            List<IMilk> milkList = new List<IMilk>()
            {
                new Latte(2),
                new Cortado(5),
                new Flat_White(3)
            };

            foreach (var coffee in orderList)
            {
                Console.WriteLine($"The Price of the {coffee.Name} is : "+ coffee.price() + " and its strenght is "+coffee.Strenght());
            }


        }
    }
}
