using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace rub2_10
{
    internal class Library
    {

        private List<Books> bookList = new List<Books>();

        public void AddBook(Books book)
        {
            bookList.Add(book);
        }
        public void FindBy(int itogs)
        {
            Console.WriteLine("Введите искомое: ");
            List<Books> result = new List<Books>();
            string choise = Console.ReadLine();
            switch (itogs)
            {
                case 1:
                    result = bookList.Where(b => b.Title == choise).ToList();
                    break;
                case 2:
                    result = bookList.Where(b => b.Author == choise).ToList();
                    break;
                case 3:
                    int year = Convert.ToInt32(choise);
                    result = bookList.Where(b => b.YearOfPublication == year).ToList();
                    break;
                case 4:
                    result = bookList.Where(b => b.Publisher == choise).ToList();
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Print(result);
        }

        public void RemoveBook(string bookTitle, string bookAuthor)
        {
            var bookToRemove = bookList.FirstOrDefault(b => b.Title == bookTitle && b.Author == bookAuthor);
            bookList.Remove(bookToRemove);
        }

        public void AddNewBook(Books book)
        {
            bookList.Add(book);
        }

        public void SortBy(int itogs)
        {
            string choise = Console.ReadLine();
            switch (itogs)
            {
                case 1:
                    bookList.Sort((a, b) => a.Title.CompareTo(b.Title)); ;
                    break;
                case 2:
                    bookList.Sort((a, b) => a.Author.CompareTo(b.Author));
                    break;
                case 3:
                    bookList.Sort((a, b) => a.YearOfPublication.CompareTo(b.YearOfPublication));
                    break;
                case 4:
                    bookList.Sort((a, b) => a.Publisher.CompareTo(b.Publisher));
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.WriteLine("Книги отсортированы");
        }

        public void GetBooks()
        {
            Print(bookList);
        }

        private void Print(List<Books> book)
        {
            if (book.Count > 0)
            {
                Console.WriteLine("Результаты поиска:");
                foreach (Books booki in book)
                {
                    Console.WriteLine($"'{booki.Title}' Автор: {booki.Author}, Год издания: {booki.YearOfPublication}, Издатель: {booki.Publisher}.");
                }
            }
            else
            {
                Console.WriteLine("Книги не найдены.");
            }
        }

    }
}
