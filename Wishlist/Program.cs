using System;
using System.Collections.Generic;

namespace Wishlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MyWishList = new List<string>();

            

            MyWishList.Add("kohvimasin");
            MyWishList.Add("Uued teksad");

            Console.WriteLine(MyWishList.Count);

            foreach(string wish in MyWishList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
