using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03.Vererbung.Buchkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Girokonto girokonto = new Girokonto(34, "Earl Jones");

            Sparkonto sparkonto = new Sparkonto(22, "Francia Jones");

            girokonto.PayIn(2000);

            sparkonto.PayIn(2000);

            girokonto.PayOut(400);

            sparkonto.PayOut(230);

            Console.ReadKey();
        }
    }
}
