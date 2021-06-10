using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter.POCO
{
    class Customer
    {
        long Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Adress { get; set; }
        string Phone { get; set; }
        string CreditCardNo { get; set; }
        long UserId { get; set; }

        User user;
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string address, string phone, string creditCardNo, long userId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Adress = address;
            Phone = phone;
            CreditCardNo = creditCardNo;
            UserId = userId;

        }

    }
}
