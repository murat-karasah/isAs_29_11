using System;

namespace switchCaseWhen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lütfen doğum yılınızı giriniz : !");
            bool control = Int32.TryParse(Console.ReadLine(), out int yil);
            if (control)
            {
                int nowyear = DateTime.Now.Year;
                int yas = nowyear - yil;
                switch (yas)
                {
                    case int kontrol when yas >= 18:
                        Console.WriteLine($"Yaşınız {yas} ,Ehliyet Alabilirsiniz :D");
                        break;
                    default:
                        Console.WriteLine($"Yaşınız {yas} ,Ehliyet için yaşınız küçük");
                        // goto;
                        break;
                }
            }
            else
            {
                Main(null);
            }
        }
    }
}
