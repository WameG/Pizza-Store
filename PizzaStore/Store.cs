using System;
namespace PizzaStore
{
    public class Store
    {
        public void Start()
        {

            Customer customer1 = new Customer(1, "John", "Johnson", "johnjohnson@email.dk", "35249034", new Order("6N9QTX", new Pizza("Veggie", 50, 1)));
            Customer customer2 = new Customer(2, "Mark", "Johnson", "Markjohnson@email.dk", "78348934", new Order("9M9LTX", new Pizza("Salat", 45, 2)));
            Customer customer3 = new Customer(3, "Rihanna", "Rocky", "rihannarocky@email.dk", "89832392", new Order("2K5TUD", new Pizza("Pepperoni", 70, 2)));

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{customer1}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{customer2}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{customer3}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
