using System;
namespace PizzaStore
{
    public class Order
    {
        string _orderNumber;
        double _tax;
        double _deliveryCost;
        Pizza _pizza;

        public Order(string orderNumber, Pizza pizza)
        {
            _orderNumber = orderNumber;
            _pizza = pizza;
            _tax = 1.25;
            _deliveryCost = 40;

        }

        public double CalculateTotalPrice()
        {
            return (_pizza.Price + _deliveryCost) * _tax;
        }

        public override string ToString()
        {
            return $"Order Details: \n\n{_pizza} \nTotal Price: {CalculateTotalPrice()} \nOrder Number: {_orderNumber}";

        }
    }
}

