using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StrandC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furdo> furdok = new List<Furdo>();
            foreach (var f in File.ReadAllLines("strandadatok.txt").Skip(1))
            {
                furdok.Add(new Furdo(f));
            }
            Console.WriteLine("7.feladat:");
            Console.WriteLine($"fürdők száma: {furdok.Count}");
            //Console.WriteLine(furdok[2].IRSZ());
            //Console.WriteLine(furdok[2].Telepules());
            Console.WriteLine("8.feladat:");
            //Console.WriteLine($"A fürdőbelépők átlagos ára: {Atlagar(furdok):f1}");
            Console.WriteLine($"A fürdőbelépők átlagos ára: {furdok.Average(f => f.Ar):f1}");
            Console.WriteLine("9.feladat");
            //Console.WriteLine(Leghidegebb(furdok));
            Console.WriteLine($"A leghidegebb víz a(z) {furdok.OrderBy(f => f.Vizhofok).First().Nev} nevű fürdőben van.");
            Console.WriteLine("10.feladat");
            Console.WriteLine("Kérem adja meg a fürdő nevét!");
            string furdoBekeres = Console.ReadLine();
            //Console.WriteLine(Furdokereso(furdok, furdoBekeres));
            int index = furdok.FindIndex(f => f.Nev == furdoBekeres);
            Console.WriteLine(index != -1 ? $"A fürdő {furdok[index].Telepules()} településen van, az irányítószám: {furdok[index].IRSZ()}":"Nincs ilyen nevű fürdő");
            Console.ReadKey();

        }
        
        public static double Atlagar(List<Furdo> furdok)
        {
            double atlag = 0;
            foreach (var f in furdok)
            {
                atlag += f.Ar;
            }
            atlag /= furdok.Count;
            return atlag;
        }

        public static string Leghidegebb(List<Furdo> furdok)
        {
            int min = 0;
            for (int i = 0; i < furdok.Count; i++)
            {
                if (furdok[i].Vizhofok < furdok[min].Vizhofok)
                {
                    min = i;
                }
            }
            return $"A leghidegebb víz a(z) {furdok[min].Nev} nevű fürdőben van.";
        }

        public static string Furdokereso(List<Furdo> furdok, string furdoBekeres)
        { 
            int i = 0;
            
            while (i < furdok.Count && furdoBekeres != furdok[i].Nev)
            {
                i++;
            }
            if (i < furdok.Count)
            {
                return $"A fürdő {furdok[i].Telepules()} településen van, az irányítószám: {furdok[i].IRSZ()}";
            }
            return "Nincs ilyen nevő fürdő";
        }
    }
}
