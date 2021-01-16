using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string.Contains__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen isminizi girniz:");
            string isim = Console.ReadLine();
            bool isimContainA = isim.Contains("a");

            if (isimContainA == false)

                Console.WriteLine("İsminde 'a' harfi olmayanlar bu grupta değiller");
            else
                Console.WriteLine("A harfini içeriyor. \nBu gruptasınız");


            Console.ReadLine();
        }
    }
}
