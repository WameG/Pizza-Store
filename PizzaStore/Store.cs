using System;
namespace PizzaStore
{
    public class Store
    {
        public void Start()
        {

            Customer customer1 = new Customer("Pernille", "Kristiansen", "Nygaardskov 2", "6067", "Rørvig", "kathrine.ottosen@pallesen.dk", "+4533140581");
            Customer customer2 = new Customer("Frederik", "Johnsen", "Mølgaardvej 256", "6402", "Børkop", "jonassen.iris@davidsen.net", "+4558100226");
            Customer customer3 = new Customer("Selma", "Hvid", "Kjeldsengade 843, st.", "3160", "Bjert", "brogaard.johan@kofod.dk", "+4552779134");

            Pizza pizza1 = new Pizza(1, "Magherita", 72);
            Pizza pizza2 = new Pizza(1, "Big Mama", 95);
            Pizza pizza3 = new Pizza(1, "Magherita", 72);

            Toppings toppings1 = new Toppings("Bacon", 14);
            Toppings toppings2 = new Toppings("Champignon", 6);
            Toppings toppings3 = new Toppings("Kebab", 14);

            Order order1 = new Order("6N9QTX", pizza1, toppings1);
            Order order2 = new Order("7K9QKF", pizza2, toppings2);
            Order order3 = new Order("4F3HFT", pizza3, toppings3);

            Payment payment1 = new Payment("Mobilepay");
            Payment payment2 = new Payment("Mastercard");
            Payment payment3 = new Payment("Visa");

            Delivery delivery = new Delivery();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Customer (#1)");
            Console.WriteLine($"{pizza1}");
            Console.WriteLine("\nToppings:");
            Console.WriteLine($"{toppings1}");
            Console.WriteLine($"{delivery}");
            Console.WriteLine($"{payment1}");
            Console.WriteLine($"{order1}");
            Console.WriteLine($"{customer1}");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Customer (#2)");
            Console.WriteLine($"{pizza2}");
            Console.WriteLine("\nToppings:");
            Console.WriteLine($"{toppings2}");
            Console.WriteLine($"{delivery}");
            Console.WriteLine($"{payment2}");
            Console.WriteLine($"{order2}");
            Console.WriteLine($"{customer2}");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Customer (#3)");
            Console.WriteLine($"{pizza3}");
            Console.WriteLine("\nToppings:");
            Console.WriteLine($"{toppings3}");
            Console.WriteLine($"{delivery}");
            Console.WriteLine($"{payment3}");
            Console.WriteLine($"{order3}");
            Console.WriteLine($"{customer3}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
