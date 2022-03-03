using System;
namespace PizzaStore
{
    public class Customer
    {
        int _customerNumber;
        string _firstName;
        string _lastName;
        string _email;
        string _phoneNumber;
        Order _order;



        public Customer(int customerNumber, string firstName, string lastName, string email, string phoneNumber, Order order)
        {
            _customerNumber = customerNumber;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _phoneNumber = phoneNumber;
            _order = order;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public override string ToString()
        {

            return $"Customer {_customerNumber}: \n\nFull Name: {_firstName} {_lastName} \nEmail: {_email} \nPhone {_phoneNumber} \n\n{_order}";
        }
    }
}
