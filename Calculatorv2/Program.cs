using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyberte požadovanou matematickou operaci: +, -, *, /");
            string operace = Console.ReadLine();

            if (operace == "+" | operace == "-" | operace == "*" | operace == "/")
            {
                Console.WriteLine("Zadejte první číslo");
                float cislo1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Zadejte druhé číslo");
                float cislo2 = float.Parse(Console.ReadLine());

                if (operace == "+")
                {
                    float soucet = cislo1 + cislo2;
                    Console.WriteLine("Součet je: " + soucet);
                    Console.ReadKey();
                }

                else if (operace == "-")
                {
                    float rozdil = cislo1 - cislo2;
                    Console.WriteLine("Rozdíl čísel je " + rozdil);
                    Console.ReadKey();
                }

                else if (operace == "*")
                {
                    float soucin = cislo1 * cislo2;
                    Console.WriteLine("Součin čísel je " + soucin);
                    Console.ReadKey();
                }

                else if (operace == "/")
                {
                    float podil = cislo1 / cislo2;
                    Console.WriteLine("Podíl čísel je " + podil);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Zadali jste neznámou matematickou operaci. Program bude ukončen");
                Console.ReadKey();
            }



        }
    }
}
