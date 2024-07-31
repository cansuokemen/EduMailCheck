using EduMailCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMailCheck
{
    public class RegisterHandler
    {
        public static void Display()
        {
            Console.WriteLine("E-posta giriniz:");
            string email = Console.ReadLine();

            Console.WriteLine("Şifrenizi giriniz:");
            string password1 = Console.ReadLine();

            bool passwordsMatch = PasswordChecker.CheckPasswords(password1);

            if (passwordsMatch)
            {
                Console.WriteLine("Girdiğiniz E-posta: " + email);
                Console.WriteLine("Girdiğiniz Şifre: " + password1);
                Console.WriteLine("Sisteme hoşgeldiniz!");
            }
        }
    }
}


