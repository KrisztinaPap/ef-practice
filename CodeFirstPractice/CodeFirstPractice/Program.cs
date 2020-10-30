using System;
using CodeFirstPractice.Models;

namespace CodeFirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ShelfContext())
            {
                Console.WriteLine("Enter shelf name to add to database: ");
                string userInput = Console.ReadLine().ToLower().Trim();

                // Citation:
                // https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database
                var shelf = new Shelf {Name = userInput};

                db.Shelves.Add(shelf);
                db.SaveChanges();
            }
        }
    }
}