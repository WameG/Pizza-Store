using System;
namespace PizzaStore
{
    public class Order
    {
        string _orderNumber;
        double _tax;
        int _deliveryCost;
        Pizza _pizza;
        Toppings _toppings;
        Payment _payment;

        public Order(string orderNumber, Pizza pizza, Toppings toppings, Payment payment)
        {
            _orderNumber = orderNumber;
            _tax = 1.25;
            _deliveryCost = 38;
            _pizza = new Pizza(pizza.Quantity, pizza.Name, pizza.Price);
            _toppings = new Toppings(toppings.Name, toppings.Price);
            _payment = new Payment(payment.Payment_Method);
        }

        public double CalculateTotalPrice()
        {
            return (_pizza.Price + _toppings.Price + _deliveryCost) * _tax;
        }

        public override string ToString()
        {
            return $"\nDelivery Cost                        {_deliveryCost} kr. \nTotal Price                      {CalculateTotalPrice()} kr. \n{_payment} \nYour ordernumber                   {_orderNumber}";

        }
    }
}

