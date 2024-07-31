using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduMailCheck
{
    public class PasswordChecker
    {
        public static bool CheckPasswords(string password1)
        {
            Console.WriteLine("Şifrenizi yeniden giriniz:");
            string password2 = Console.ReadLine();

            while (password1 != password2)
            {
                Console.WriteLine("Şifreler uyuşmuyor. Lütfen aynı şifreyi giriniz.");
                Console.WriteLine("Şifrenizi giriniz:");
                password1 = Console.ReadLine();
                Console.WriteLine("Şifrenizi yeniden giriniz:");
                password2 = Console.ReadLine();
            }

            return true;
        }
    }
}

