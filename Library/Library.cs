using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Library
    {
        private Book[] Books;
        private Customer[] Customers;

        public Library()
        {
            Books = new Book[3] {

                 new Book {
                     Name = "Tutunamayanlar",
                     PageCount = 700,
                     Author = "Oğuz Atay",
                     Shelf = 11
                 },

                  new Book
                  {
                      Name = "Tutunanlar",
                      PageCount = 700,
                      Author = "Oğuz Atay",
                      Shelf = 11
                  },
                  new Book
                  {
                      Name = "Tutunmuş kimi olanlar",
                      PageCount = 700,
                      Author = "Oğuz Atay",
                      Shelf = 11
                  }

            };

            Customers = new Customer[3]
            {
                new Customer
                {
                    Name= "Elvin",
                    Surname = "Babasov",
                },
                new Customer
                {
                    Name= "Terlan",
                    Surname = "Usubov",
                },

                new Customer
                {
                    Name= "Cavid",
                    Surname = "Tagyev",
                }
            };
        }

        public string[] GetBooks()
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

        public string[] GetCustomers()
        {
            string[] customerNames = new string[Customers.Length];

            for (int i = 0; i < Books.Length; i++)
            {
                if (Customers[i] != null)
                {
                    customerNames[i] = Customers[i].Name;
                }
            }

            return customerNames;
        }
    }
}