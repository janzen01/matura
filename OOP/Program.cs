using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Zdravic zdravic = new Zdravic();
            zdravic.text = "Ahoj uživateli";
            Console.WriteLine(zdravic.Pozdrav("Karel"));
            Console.WriteLine(zdravic.Pozdrav("Luboš"));
            zdravic.text = "Vítej programátore";
            Console.WriteLine(zdravic.Pozdrav("Davide"));
            Console.ReadKey();
        }
    }
}
