using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapilari_4
{
    class Program
    {
        static void Main(string[] args)
        {
            long deger = Convert.ToInt64(Console.ReadLine());
            if (deger == 100)
            {
                Console.Write("fizz");
            }
            else if (deger == 50)
            {
                Console.Write(":)");
            }
            else if (deger == 0)
            {
                Console.Write("buzz");
            }
            else
            {
                Console.Write(deger);
            }
            Console.ReadKey();
        }
    }
}
// else if deyimi: Birden fazla koşul kontrol edilmek isteniyorsa kullanılan yapıdır.
// Kullanıcıdan alınan değer 100 ise "fizz", 50 ise ":)", 0 ise "buzz", bu ihtimallerden hiçbiri değilse değeri tekrar kullanıcıya gösteren program.