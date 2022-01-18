using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Book[] Books { get; set; }

        public Customer()
        {
            Books = new Book[3];
        }


        public string[] GetOwnedBooks()
        {
            string[] bookNames = new string[Books.Length];

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i] != null)
                {
                    bookNames[i] = Books[i].Name;
                }
            }

            return bookNames;
        }
    }
}