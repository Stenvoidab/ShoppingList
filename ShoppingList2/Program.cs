using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList2
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileLocation = @"C:\Users\stens\OneDrive\Töölaud\TTK\programeerimine\Nädal 8 - failid-20220314\Shopping list";
            string fileName = @"//shopping list.txt";

            string[] ArrayFromFile = File.ReadAllLines($"{FileLocation}{fileName}");

            List<string> MyWishlist = ArrayFromFile.ToList<string>();

            bool loopactive = true;

            while (loopactive)
            {
                Console.WriteLine("Would yuu like to add a new product? Y/N ");
                char userinput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userinput == 'y')
                {
                    Console.WriteLine("Enter new product.");
                    string UserWish = Console.ReadLine();
                    MyWishlist.Add(UserWish);
                }
                else
                {
                    loopactive = false;
                    Console.WriteLine("y or n only!");
                }
                Console.Clear();

                

                File.WriteAllLines($"{FileLocation}{fileName}", MyWishlist);
            }
        }
    }
}
