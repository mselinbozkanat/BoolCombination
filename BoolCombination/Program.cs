using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolCombination
{
    class Program
    {
        public static string d = "t";

        public static string y = "f";

        public static int adet;


        static void Main(string[] args)
        {

            Console.WriteLine("Kaç adet True, False için tüm kombinasyonları görmek istiyorsunuz?");
            adet = Convert.ToInt32(Console.ReadLine());
            if (adet != 0)
                BoolCombination1(adet, "");

            Console.ReadKey();

        }

        static void BoolCombination1(int n, string a)
        {

            if (n > 0)
            {
                BoolCombination1(n - 1, a + "t");
                BoolCombination1(n - 1, a + "f");
                return;
            }

            Console.WriteLine(a);
        }
    }
}
