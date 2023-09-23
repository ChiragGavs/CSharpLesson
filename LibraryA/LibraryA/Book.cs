using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryA
{
    public class Book
    {
        public string Title = string.Empty;
        public string Author = string.Empty;
        public string Genre = string.Empty;
        public DateTime DateOfPublish;
        public int BookPrice;
        public int TotalPages = 300; 

        public void OpenBook()
        {
            Console.WriteLine($"book is open !!!!");
        }

        public void BookMark( int PageNo) { Console.WriteLine($"page number : {PageNo} Bookmarked.");}

        public int GetCurrentPage()
        {
            Random rnd = new Random();
            return rnd.Next(TotalPages);
        }
    }
}
