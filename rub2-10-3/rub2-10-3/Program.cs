namespace rub2_10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var CustomerDescribed = new List<Customer>()
            {
                new Customer("Иванов", "Иван", "Иванович", "ул. Иркутский Тракт 85", "1111 1111 1111", "1234567890"),
                new Customer("Туве", "Мария", "Янсон", "ул. Ленина 2", "1001 1221 1331", "0012003400"),
                new Customer("Эндрю", "Том", "Хасси", "ул. Тверская 6", "3141 2121 0420", "1122334455"),
            };

            while(true )
            {
                Console.WriteLine("1:  Выведите список покупателей в алфавитном порядке. \n" +
                    "2:  Выведите список покупателей у которых номер кредитной карточки находится в заданном диапазоне. \n" +
                    "3: Выйти из меню");
                int Dummy = Convert.ToInt32(Console.ReadLine());
                switch(Dummy)
                {
                    case 1:
                        Console.WriteLine("Список покупателей, отсортированных по фамилии:");
                        CustomerDescribed.Sort((c1, c2) => string.Compare(c1.LastName, c2.LastName));
                        foreach (Customer customer in CustomerDescribed)
                        {
                            Console.WriteLine($"ФИО: {customer.LastName} {customer.FirstName} {customer.Patronymic}.\n Адрес: {customer.Address} \n Номер кредитной карточки: {customer.CreditCardNumber} Номер банковского счета: {customer.BankAccountNumber}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите начальный номер кредитной карточки:");
                        string startCard = Console.ReadLine();
                        Console.WriteLine("Введите конечный номер кредитной карточки:");
                        string endCard = Console.ReadLine();

                        var filteredCustomers = CustomerDescribed.Where(c => c.IsCreditCardNumberInRange(c.CreditCardNumber, startCard, endCard));

                        if (filteredCustomers.Any())
                        {
                            Console.WriteLine("Список покупателей, с номер кредитной карточки находящемся в заданном д  иапазоне:");
                            foreach (Customer customer in filteredCustomers)
                            {
                                Console.WriteLine($"{customer.LastName} {customer.FirstName} {customer.Patronymic} {customer.Address} {customer.CreditCardNumber} {customer.BankAccountNumber}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет покупателей, с подобным номером кредитной карточки.");
                        }
                        ; break;
                    case 3:

                        ; return;
                    default: Console.WriteLine("ERROR"); break;
                }
            }

        }
    }
}