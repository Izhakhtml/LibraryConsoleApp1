using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp1
{
    class Book
    {
        public string bookName;
        public string writer;
        public int numbersPages;
        public Book (string bookName,string writer,int numbersPages)
        {
            this.bookName = bookName;
            this.writer = writer;
            this.numbersPages = numbersPages;
        }
        public Book() { }
    }
}
