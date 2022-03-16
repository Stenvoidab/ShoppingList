using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
             
            string RootDirectory = @"C:\Users\stens\OneDrive\Töölaud\TTK\programeerimine\Nädal 8 - failid-20220314";
            Console.WriteLine("Enter directory name.");
            string NewDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name.");
            string FileName = Console.ReadLine();
            if(Directory.Exists(@$"{RootDirectory}\\{NewDirectory}") && File.Exists($@"{RootDirectory}\\{NewDirectory}\\{FileName}"))
            {
                Console.WriteLine($"Directory of file already exist");
            }
            else
            {
                Directory.CreateDirectory(@$"{RootDirectory}\\{NewDirectory}");
                File.Create($"{RootDirectory}\\{NewDirectory}\\{FileName}");
            }
        }

    }
}
