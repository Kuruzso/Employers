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
            //1.feladat
            string[] adat = File.ReadAllLines("tulajdonsagok_100sor.txt");
            //2.feladat
            List<dolgozo> tulajdonsagLista = new List<dolgozo>();

            foreach (var sor in adat)
            {
                tulajdonsagLista.Add(new dolgozo(sor));
            }
            //3.feladat
            foreach (var item in tulajdonsagLista)
            {
                Console.WriteLine(item.nev);
            }
            //4.feladat
            int index = 0;
            for (int i = 0; i < tulajdonsagLista.Count; i++)
            {
                if (tulajdonsagLista[index].kereset < tulajdonsagLista[i].kereset)
                {
                    index = i;
                }
            }
            Console.WriteLine(tulajdonsagLista[index].azonosito+" ," + tulajdonsagLista[index].nev);

            for (int i = 0; i < tulajdonsagLista.Count; i++)
            {
                if (tulajdonsagLista[i].kor == 55)
                {
                    Console.WriteLine(tulajdonsagLista[i].nev+" " + tulajdonsagLista[i].kor);
                }
            }

            Console.ReadLine();

        }
    }
}
