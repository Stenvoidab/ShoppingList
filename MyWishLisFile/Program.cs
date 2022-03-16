using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyWishLisFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileLocation = @"C:\Users\stens\OneDrive\Töölaud\TTK\programeerimine\Nädal 8 - failid-20220314\Wishlist";
            string fileName = @"//Wishlist.txt";

            string[] ArrayFromFile = File.ReadAllLines($"{FileLocation}{fileName}");

            List<string> MyWishlist = ArrayFromFile.ToList<string>();

            bool loopactive = true;

            while(loopactive)
            {
                Console.WriteLine("Would yuu like to add a wish? Y/N");
                char userinput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userinput == 'y')
                {
                    Console.WriteLine("Enter your wish.");
                    string UserWish = Console.ReadLine();
                    MyWishlist.Add(UserWish);
                }
                else
                {
                    loopactive = false;
                    Console.WriteLine("yes or no answers only");
                }

            }

            Console.Clear();

            foreach(string wish in MyWishlist)
            {
                Console.WriteLine(wish);
            }

            File.WriteAllLines($"{FileLocation}{fileName}", MyWishlist);


        }
    }
}
