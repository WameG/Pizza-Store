using System;
namespace PizzaStore
{
    public class Payment
    {
        string _paymentMethod;

        public Payment(string paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public string Payment_Method
        {
            get { return _paymentMethod; }
        }

        public override string ToString()
        {
            return $"Payment Method                 ({Payment_Method})";
        }
    }
}
