using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_P1_Q1
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }

        public void DisplayBookInfo()
        {
            Console.WriteLine("Book Details : ");
            Console.WriteLine($"Book Title : {Title}");
            Console.WriteLine($"Book Author : {Author}");
            Console.WriteLine($"Book ISBN : {ISBN}");
            Console.WriteLine($"Book Price : {Price:F2}");

        }
        public void ApplyDiscount(double percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Invalid Discount amount, PLease enter between 0 and 100!");
            }
            double discountAmount = (Price * percentage) / 100;
            Price -= discountAmount;
            Console.WriteLine($"Discount of {percentage}% applied, New price is : {Price}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Murder of History";
            book1.Author = "KK Aziz";
            book1.ISBN = "789564523";
            book1.Price = 999;
            book1.DisplayBookInfo();
            book1.ApplyDiscount(10);
            book1.DisplayBookInfo();

            Console.WriteLine("\t---***---");

            Book book2 = new Book();
            book2.Title = "Mushaf";
            book2.Author = "Nimra Ahmed";
            book2.ISBN = "88749654263";
            book2.Price = 1499;
            book2.DisplayBookInfo();
            book2.ApplyDiscount(10);
            book2.DisplayBookInfo();


        }
    }
}
