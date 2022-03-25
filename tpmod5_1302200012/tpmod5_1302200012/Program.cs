using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod5_1302200012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo a = new SayaTubeVideo("Tutorial Design By Contract – Resty ");
            a.PrintVideoDetails();

            Console.WriteLine("\n");

            SayaTubeVideo b = new SayaTubeVideo("Google LLC adalah sebuah perusahaan multinasional Amerika Serikat yang berkekhususan pada jasa dan produk Internet. Produk-produk tersebut meliputi teknologi pencarian, komputasi web, perangkat lunak, dan periklanan daring");
            b.PrintVideoDetails();

            Console.WriteLine("\n");

            a.IncreasePlayCount(24);
            a.PrintVideoDetails();
            a.IncreasePlayCount(11000000);
            a.PrintVideoDetails();

        }
    }
}
