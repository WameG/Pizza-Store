using System;
namespace PizzaStore
{
    public class Toppings
    {
        string _name;
        int _price;
        int _quantity;

        public Toppings(string name, int price)
        {
            _name = name;
            _price = price;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public override string ToString()
        {
            return $"{Name}                        (+{Price} kr.)";
        }
    }
}
