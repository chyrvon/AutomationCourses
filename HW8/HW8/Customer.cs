using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using HW8.Helper;

namespace HW8
{
    [DataContract]
    public class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _phone;

        [DataMember]
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                Regex dictionaryChars = new Regex("^[a-zA-Zа-яА-Я]*$");
                if (!dictionaryChars.IsMatch(value) || (value.Length < 3) || (value.Length > 20))
                {
                    value = "WrongFirstName";
                    Console.WriteLine($"Wrong value, replaced to: {value}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                _firstName = value;
            }
        }

        [DataMember]
        public string LastName 
        {
            get
            {
                return _lastName;
            }
            set
            {
                Regex dictionaryChars = new Regex("^[a-zA-Zа-яА-Я]*$");
                if (!dictionaryChars.IsMatch(value) || (value.Length < 3) || (value.Length > 20))
                {
                    value = "WrongLastName";
                    Console.WriteLine($"Wrong value, replaced to: {value}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                _lastName = value;
                
            }
        }

        [DataMember]
        public Guid CustomerID { get; set; }

        [DataMember]
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                Regex dictionaryNumbers = new Regex("^[0-9a-fA-F]*$");
                if (!dictionaryNumbers.IsMatch(value) || (value.Length < 3) || (value.Length > 20))
                {
                    value = "12345";
                    Console.WriteLine($"Wrong phone value, replaced to: {value}");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                _phone = value;
            }
        }

        public Customer ()
        {
            FirstName = GetValue.ReadValueFromConsole("Enter First Name: ");
            LastName = GetValue.ReadValueFromConsole("Enter Last Name: ");
            CustomerID = Guid.NewGuid();
            Phone = GetValue.ReadValueFromConsole($"Enter phone: ", isPhone: true);
        }

        public static Customer VerifyCustomerOnBase(Customer getCustomerFromConsole, List<Customer> customers)
        {
            return customers.FirstOrDefault(x =>
                                x.FirstName.Equals(getCustomerFromConsole.FirstName) &&
                                x.LastName.Equals(getCustomerFromConsole.LastName) &&
                                x.Phone.Equals(getCustomerFromConsole.Phone));
        }
    }
}
