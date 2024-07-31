using System;
using EduMailCheck;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Menu.Display();
            Menu.Read();
            Console.WriteLine("Devam etmek için bir tuşa basınız...");
            Console.ReadKey(); // Wait for the user to press a key
            Console.Clear(); // Clear the console for a clean output
        }
    }
}