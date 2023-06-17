using System.Collections.Generic;
using System.Globalization;
using static System.Reflection.Metadata.BlobBuilder;

namespace rub2_10
{
    internal class Program
    {
        //Задание 1.
        static void Main(string[] args)
        {
            Library homeLibrary = new Library();

            homeLibrary.AddBook(new Books("Мистические рассказы", "Эдгар По", 2021, "Дримбук"));
            homeLibrary.AddBook(new Books("Тревожные люди", "Фредерик Бакман", 2020, "Синдбад"));
            homeLibrary.AddBook(new Books("Все о муми-троллях. Книга 2", "Туве Янссон", 2022, "Азбука"));
            homeLibrary.AddBook(new Books("Затаившийся страх", "Говард Лавкрафт", 2022, "АСТ"));
            homeLibrary.AddBook(new Books("Проза бродячих псов", "Кафка Асагири", 2021, "XL Media"));
            homeLibrary.AddBook(new Books("Гарри Поттер и Философский Камень", "Ролинг Джоан Кэтлин", 2007, "Росмэн"));

            while (true)
            {

                Console.WriteLine("1: Найти книгу. \n" +
                    "2: Удалить книгу. \n" +
                    "3: Добавить книгу. \n" +
                    "4: Сортировать. \n" +
                    "5: Выписать все книги. \n" +
                    "6: Выйти из меню");
                int Dummy = Convert.ToInt32(Console.ReadLine());
                switch (Dummy)
                {
                    case 1:
                        Console.WriteLine("Поиск по. \n" +
                            "1: Названию книги. \n" +
                            "2: Имени автора. \n" +
                            "3: Году выпуска. \n" +
                            "4: Названию издательства");
                        int itog = Convert.ToInt32(Console.ReadLine());
                        homeLibrary.FindBy(itog);
                        break;
                    case 2:
                        Console.WriteLine("Введите данные о книге, которую нужно удалить \n" +
                            "Название:");
                        string bookTitle = Console.ReadLine();
                        Console.WriteLine("Автор:");
                        string bookAuthor = Console.ReadLine();
                        homeLibrary.RemoveBook(bookTitle, bookAuthor);
                       ; break;
                    case 3:
                        Console.WriteLine("Для добавления новой книги, заполните необходимые поля.\n" +
                            "Название:");
                        string booksTitle = Console.ReadLine();
                        Console.WriteLine("Автор:");
                        string booksAuthor = Console.ReadLine();
                        Console.WriteLine("Год выпуска:");
                        int booksYear = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Автор:");
                        string booksPublisher = Console.ReadLine();
                        homeLibrary.AddBook(new Books(booksTitle, booksAuthor, booksYear, booksPublisher));
                        Console.WriteLine("Книга добавлена.");
                        ; break;
                    case 4:
                        Console.WriteLine("Сортировка по. \n" +
                            "1: Названию книги. \n" +
                            "2: Имени автора. \n" +
                            "3: Году выпуска. \n" +
                            "4: Названию издательства");
                        itog = Convert.ToInt32(Console.ReadLine());
                        homeLibrary.SortBy(itog);
                        ; break;
                    case 5:
                        Console.WriteLine("Список книг в библиотеке:");
                        homeLibrary.GetBooks();
                         ; break;
                    case 6:; return;
                }
            }
        }
    }
}