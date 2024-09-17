using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Employers
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adat = File.ReadAllLines("tulajdonsagok_100sor.txt");
            List<dolgozo> tulajdonsagLista = new List<dolgozo>();
            foreach (var sor in adat)
            {
                tulajdonsagLista.Add(new dolgozo(sor));
            }
            foreach (var item in tulajdonsagLista)
            {
                Console.WriteLine(item.nev);
            }
        }
    }
}
