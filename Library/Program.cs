using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library axundov = new Library();

            Customer customer = new Customer();
            customer.Name = "Elvin";

            bool exit = false;



            while (exit == false)
            {
                Console.WriteLine("1 - Bütün kitablar");
                Console.WriteLine("2 - Bütün istifadəçilər");

                int processNumber;
                string consoleText = Console.ReadLine();
                if (int.TryParse(consoleText, out processNumber) == false)
                {
                    Console.WriteLine("Düzgün rəqəm daxil edin.");
                    continue;
                }

                if (processNumber == 1)
                {
                    string[] result = axundov.GetBooks();
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] != null)
                        {
                            Console.WriteLine(result[i]);
                        }
                    }
                }
                else if (processNumber == 2)
                {
                    string[] result = axundov.GetCustomers();
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] != null)
                        {
                            Console.WriteLine(result[i]);
                        }
                    }
                }
                else if (processNumber == 3)
                {
                    string[] result = customer.GetOwnedBooks();
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i] != null)
                        {
                            Console.WriteLine(result[i]);
                        }
                    }
                }
                else if (processNumber == 0)
                {
                    exit = true;
                }

            }
        }


    }
}