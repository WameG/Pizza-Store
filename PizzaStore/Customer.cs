using System;
namespace PizzaStore
{
    public class Customer
    {
        int _customerNumber;
        string _firstName;
        string _lastName;
        string _address;
        string _postcode;
        string _city;
        string _email;
        string _phoneNumber;



        public Customer(string firstName, string lastName, string address, string postcode, string city, string email, string phoneNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _postcode = postcode;
            _city = city;
            _email = email;
            _phoneNumber = phoneNumber;
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

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
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

            return $"\nOplysninger: \n\n{FirstName} {LastName} \n{Address} \n{Postcode} {City} \n{Email} \n{PhoneNumber}";
        }
    }
}
