using System;
using Bakery.Models;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Bread is $5 per loaf, and pastries are $2 each.");
            Console.WriteLine("We have a special deal: buy two loaves of bread, get one free, and buy three pastries, get one free.");
            Console.WriteLine("How many loaves of bread would you like to order?");
            int breadOrder = int.Parse(Console.ReadLine());
            Bread bread = new Bread(breadOrder);
            Console.WriteLine("How many pastries would you like to order?");
            int pastryOrder = int.Parse(Console.ReadLine());
            Pastry pastry = new Pastry(pastryOrder);
            int totalCost = bread.OrderCost + pastry.OrderCost;
            Console.WriteLine($"Your order is {breadOrder} loaves of bread and {pastryOrder} pastries.");
            Console.WriteLine($"Your total cost is ${totalCost}.");
        }
    }
}