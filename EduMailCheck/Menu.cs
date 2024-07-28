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

                switch (input)
                {
                    case "1":
                        Console.WriteLine("1'e bastınız.");
                        validInput = true;
                        break;
                    case "2":
                        Console.WriteLine("2'ye bastınız.");
                        validInput = true;
                        break;
                    case "3":
                        Console.WriteLine("Çıkış yapılıyor.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                        break;
                }
            }
        }
    }
}

    


