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
            Console.WriteLine("1.feladat : beolvassa a fájlt");
            string[] adat = File.ReadAllLines("tulajdonsagok_100sor.txt");
            Console.WriteLine();
            //2.feladat
            Console.WriteLine("2.feladat : eltárolja a fájlt");
            List<dolgozo> tulajdonsagLista = new List<dolgozo>();

            foreach (var sor in adat)
            {
                tulajdonsagLista.Add(new dolgozo(sor));
            }
            Console.WriteLine();
            //3.feladat
            Console.WriteLine("3.feladat : megjeleníti az összes dolgozó nevét");
            foreach (var item in tulajdonsagLista)
            {
                Console.WriteLine(item.nev);
            }
            Console.WriteLine();
            //4.feladat
            Console.WriteLine("4.feladat : ki írja  azon dolgozók azonosítóját és nevét akik a legjobban keresnek");
            int index = 0;
            for (int i = 0; i < tulajdonsagLista.Count; i++)
            {
                if (tulajdonsagLista[index].kereset < tulajdonsagLista[i].kereset)
                {
                    index = i;
                }
            }
            Console.WriteLine(tulajdonsagLista[index].azonosito+" ," + tulajdonsagLista[index].nev);
            Console.WriteLine();
            //5.feladat
            Console.WriteLine("5.feladat : ki írja azoknak a nevét akiknek 10 évük van nyugdíjig");
            for (int i = 0; i < tulajdonsagLista.Count; i++)
            {
                if (tulajdonsagLista[i].kor == 55)
                {
                    Console.WriteLine(tulajdonsagLista[i].nev+" " + tulajdonsagLista[i].kor);
                }
            }
            Console.WriteLine();
            //6.feladat
            Console.WriteLine("6.feladat : megszámolja hanyan keresnek 50000 felett");
            int hanyan = 0;
            for (int i = 0; i < tulajdonsagLista.Count; i++)
            {
                if (tulajdonsagLista[i].kereset > 50000)
                {
                    hanyan++;
                }
            }
            Console.WriteLine(hanyan+"-en/an keresnek 50000 felett");


            Console.ReadLine();

        }
    }
}
