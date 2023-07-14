using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeveKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.TCKIMLIKNO = "12345678989";
            Console.WriteLine("TC kimlik numaranız:" +P1.TCKIMLIKNO);
        }
    }
}
