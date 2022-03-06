using System;
namespace PizzaStore
{
    public class Delivery
    {
        int _price;

        public Delivery()
        {
            _price = 38;
        }

        public int Price
        {
            get { return _price; }
        }

        public override string ToString()
        {
            return $"\nDelivery Costs                       {Price} kr.";
        }
    }
}
