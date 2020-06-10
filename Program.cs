using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvniaplikace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v aplikaci kalkulačka");
            Console.WriteLine("Zadejte první číslo");
            float cislo1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo");
            float cislo2 = float.Parse(Console.ReadLine());
            float soucet = cislo1 + cislo2;
            float rozdil = cislo1 - cislo2;
            float soucin = cislo1 * cislo2;
            float podil = cislo1 / cislo2;
            Console.WriteLine("Součet je: " + soucet.ToString());
            Console.WriteLine("Rozdíl je: " + rozdil.ToString());
            Console.WriteLine("Součin je: " + soucin.ToString());
            Console.WriteLine("Podíl je: " + podil.ToString());
            Console.ReadKey();
        }
    }
}
