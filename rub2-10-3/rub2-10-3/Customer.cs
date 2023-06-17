using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rub2_10_3
{
    internal class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public string CreditCardNumber { get; set; }
        public string BankAccountNumber { get; set; }

        private List<Customer> customers = new List<Customer>();
        public Customer(string lastName, string firstName, string patronymic, string address, string creditCardNumber, string bankAccountNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Address = address;
            CreditCardNumber = creditCardNumber;
            BankAccountNumber = bankAccountNumber;
        }
        public bool IsCreditCardNumberInRange(string CreditCardNumber, string startCard, string endCard)
        {
            return string.Compare(CreditCardNumber, startCard) >= 0 && string.Compare(CreditCardNumber, endCard) <= 0;
        }
    }
}
