using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rub2_10
{
    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public string Publisher { get; set; }

        public Books(string title, string author, int year, string publisher)
        {
            Title = title;
            Author = author;
            YearOfPublication = year;
            Publisher = publisher;
        }
    }
}
