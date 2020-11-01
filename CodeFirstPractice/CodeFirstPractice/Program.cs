using System;
using System.Diagnostics;
using System.Linq.Expressions;
using CodeFirstPractice.Migrations;
using CodeFirstPractice.Models;

namespace CodeFirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ShelfContext())
            {
                bool materialValid = false;
                Console.WriteLine("Enter shelf name: ");
                string newShelf = Console.ReadLine().ToLower().Trim();
                if (newShelf != "")
                {
                    do
                    {
                        // Shoutout to Lindsey Graham for clarifying what exactly the instructions required in this program!
                        Console.WriteLine("Choose shelf material: (Enter number or type in name)");
                        Console.WriteLine("1. Oak\n2. Spruce\n3. Birch\n4. Acacia");
                        int MaterialCode = 0;
                        string userInput = Console.ReadLine().Trim().ToLower();
                        if ((userInput == "oak") || (userInput == "spruce") || (userInput == "birch") ||
                            (userInput == "acacia"))
                        {
                            if (userInput == "oak")
                            {
                                MaterialCode = -1;
                                materialValid = true;
                            }
                            else if (userInput == "spruce")
                            {
                                MaterialCode = -2;
                                materialValid = true;
                            }
                            else if (userInput == "birch")
                            {
                                MaterialCode = -3;
                                materialValid = true;
                            }
                            else if (userInput == "acacia")
                            {
                                MaterialCode = -4;
                                materialValid = true;
                            }
                            // Citation:
                            // https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database
                            var shelf = new Shelf {Name = newShelf, ShelfMaterialID = MaterialCode};

                            db.Shelves.Add(shelf);
                            db.SaveChanges();
                            Console.WriteLine($"{newShelf} was added to the database.");
                        }
                        else
                        {
                            try
                            {
                                int.TryParse(userInput, out MaterialCode);

                                switch (MaterialCode)
                                {
                                    case 1:
                                        MaterialCode = -1;
                                        materialValid = true;
                                        break;
                                    case 2:
                                        MaterialCode = -2;
                                        materialValid = true;
                                        break;
                                    case 3:
                                        MaterialCode = -3;
                                        materialValid = true;
                                        break;
                                    case 4:
                                        MaterialCode = -4;
                                        materialValid = true;
                                        break;
                                }

                                // Citation:
                                // https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/existing-database
                                var shelf = new Shelf {Name = newShelf, ShelfMaterialID = MaterialCode};

                                db.Shelves.Add(shelf);
                                db.SaveChanges();
                                
                                Console.WriteLine($"{newShelf} was added to the database.");
                            }
                            catch
                            {
                                Console.WriteLine("Invalid choice. Thank you for using our program.");
                            }
                        }
                      
                    } while (materialValid == false);
                }
            }
        }
    }
}