using System;

namespace BasitMethodTanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
         // int a = 6,b = 8;
         // Console.WriteLine(ToplamAl(a, b));
         // saatkac();
         // merhaba();
            Console.WriteLine("1.Değeri giriniz");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Değeri giriniz ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.Değeri giriniz");
            int e = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Alanı : " + carpma(c,d,e));
        }

        static float carpma(int c, int d, int e)
        {
            Console.WriteLine(@"
                                              .
                                c : {0}      / \     d: {1}
                                            /   \
                                           /     \
                                          /_______\
                                           e : {2}            





", c, d, e);
            float sonuc=0;
            switch (c)
            {
             
                case int kontrol when c == d && c==e:
                    Console.WriteLine("Eşkenar Üçgen");
                 
                    sonuc = (float)((c * c) * Math.Sqrt(3) / 4);
               

                    break;

                case int kontrol when (c == d || c==e || d==e) && (c != e || d !=e):
                    
                    Console.WriteLine("İkizkenar Üçgen");
                    float h = (c + d + e)/ 2;
                    sonuc = (float)Math.Sqrt((h*((h-c)*(h-d)*(h-e))));
                                  break;
                case int kontrol when c !=d && c !=e && d!=e:
                    Console.WriteLine(" Üçgen");
                     h = (c + d + e) / 2;
                    sonuc = (h*d);
                    break;
                default:
                    Console.WriteLine("algılanamadı");
                    break;
            }
            return sonuc;
        }

        //private static void merhaba()
        //{
        //    Console.WriteLine("merhaba");    
        //}

        //private static void saatkac()
        //{
        //    Console.WriteLine(DateTime.Now.Hour);   
        //}

        //static int ToplamAl(int a, int b)
        //{
        //    int sonuc = a + b;
        //    return sonuc; 
        //}
    }
}
