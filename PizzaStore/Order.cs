using System;
namespace PizzaStore
{
    public class Order
    {
        string _orderNumber;
        double _tax;
        Pizza _pizza;
        Toppings _toppings;
        Delivery _delivery;

        public Order(string orderNumber, Pizza pizza, Toppings toppings)
        {
            _orderNumber = orderNumber;
            _tax = 1.25;
            _delivery = new Delivery();
            _pizza = new Pizza(pizza.Quantity, pizza.Name, pizza.Price);
            _toppings = new Toppings(toppings.Name, toppings.Price);
        }

        public double CalculateTotalPrice()
        {
            return (_pizza.Price + _toppings.Price + _delivery.Price) * _tax;
        }

        public override string ToString()
        {
            return $"Total Price                      {CalculateTotalPrice()} kr. \nYour ordernumber                   {_orderNumber}";

        }
    }
}

