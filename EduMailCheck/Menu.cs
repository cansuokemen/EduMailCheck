using System;

namespace EduMailCheck
{
    public class Menu
    {
        public static void Display()
        {
            var LoginContent = "1- Giriş yapmak için 1'e basınız.";
            var RegisterContent = "2- Kayıt olmak için 2'ye basınız.";
            var ExitContent = "3- Çıkmak için 3'e basınız.";

            Console.WriteLine(LoginContent + "\n" + RegisterContent + "\n" + ExitContent);
        }

        public static void Read()
        {
            bool validInput = false;

            while (!validInput)
            {
                var input = Console.ReadLine();

                if (input == "1")
                {
                    LoginHandler.Display();
                    validInput = true;
                }
                else if (input == "2")
                {
                    RegisterHandler.Display();
                    validInput = true;
                }
                else if (input == "3")
                {
                    Console.WriteLine("Çıkış yapılıyor.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                }
            }
        }
    }

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