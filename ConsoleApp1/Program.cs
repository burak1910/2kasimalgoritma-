using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Random rnd = new Random();
            int sayi = rnd.Next(0,20);
            bool dogru = false;
            int sayi2;
            for (int i = 0; dogru == false; i++)
            {

                Console.WriteLine("0-20 arası bir sayı giriniz");
                Console.WriteLine("Random değişken: "+sayi);
                sayi2 = Convert.ToInt32(Console.ReadLine());
                if (sayi2 == sayi)
                {
                    Console.WriteLine("Doğru Bildiniz");
                    dogru = true;
                }
                else if (sayi2 > sayi)
                {
                    Console.WriteLine("Daha küçük bir sayı girin");
                }
                else if (sayi2< sayi)
                {
                    Console.WriteLine("Daha büyük bir sayı girin");
                }
                else
                {
                    Console.WriteLine("Yanlış Girdiniz tekrar");
                }
            }
             
        }
    }
}

