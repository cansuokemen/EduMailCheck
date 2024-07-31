using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EduMailCheck
{
    public class LoginHandler
    {
        public static void Display()
        {
            Console.WriteLine("E-posta giriniz:");
            string email = Console.ReadLine();

            Console.WriteLine("Şifrenizi giriniz:");
            string password = Console.ReadLine();

            Console.WriteLine("Girdiğiniz E-posta: " + email);
            Console.WriteLine("Girdiğiniz Şifre: " + password);
        }
    }
}