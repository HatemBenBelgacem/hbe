﻿using System;
using System.Collections;
using System.Linq.Expressions;
using Microsoft.VisualBasic;

namespace Name
{
    class Zahlen
    {
        int tippZahl = 0;
        int sternZahl = 0;
        static void Main(string[] args)
        {
            Zahlen zahl = new Zahlen();
            var tipp = new Random();
            var stern = new Random();
            ArrayList tippListe = new ArrayList();
            ArrayList sternListe = new ArrayList();



            while (tippListe.Count < 5)
            {
            zahl.tippZahl = tipp.Next(1, 51);
            if (!tippListe.Contains(zahl.tippZahl))
            {
                tippListe.Add(zahl.tippZahl);
                tippListe.Sort();
            }

            }
            while(sternListe.Count < 2)
            {
                zahl.sternZahl = stern.Next(1,13);
                if (!sternListe.Contains(zahl.sternZahl))
                {
                    sternListe.Add(zahl.sternZahl);
                    sternListe.Sort();
                }
            }
            Console.WriteLine("Tipp: ");
            foreach (object t in tippListe)
            {
                Console.Write(t + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Stern: "); 
            foreach (object s in sternListe)
            {
                Console.Write(s + ", ");
            }
        }
    }
}


