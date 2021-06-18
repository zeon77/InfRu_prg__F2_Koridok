using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AutóVerseny
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. feladat: beolvasás
            List<Versenyző> versenyzők = new List<Versenyző>();
            foreach (var sor in File.ReadAllLines(@"autoverseny.csv").Skip(1))
                versenyzők.Add(new Versenyző(sor));

            //3. feladat
            Console.WriteLine($"3. feladat: {versenyzők.Count()}");

            //4. feladat
            Versenyző FF = versenyzők.Single(v => v.Név == "Fürge Ferenc" && v.Pálya == "Gran Prix Circuit" && v.Kör == 3);
            Console.WriteLine($"4. feladat: {FF.Köridő.TotalSeconds} másodperc");

        }
    }
}
