using System;
namespace PizzaStore
{
    public class Payment
    {
        string _name;

        public Payment(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public override string ToString()
        {
            return $"Payment Method                 ({Name})";
        }
    }
}
