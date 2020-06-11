using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Zdravic
    {
        public string text;
        
        public string Pozdrav(string jmeno)
        {
            return string.Format("{0} {1}", text, jmeno);
        }
    }
}
