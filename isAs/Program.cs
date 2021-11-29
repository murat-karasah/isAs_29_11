using System;

namespace isAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veri giriniz");
            int a = 5;
            string s =Console.ReadLine();
            if (s is string)
            {
                Console.WriteLine($"Verinin tipi string") ;
            }
        }
    }
}
