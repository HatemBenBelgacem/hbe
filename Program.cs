using System;
using System.Collections;
using System.Linq.Expressions;
using Microsoft.VisualBasic;

namespace Name
{
    class Zahlen
    {
        int zufallsZahl = 0;
        static void Main(string[] args)
        {
            Zahlen zahl = new Zahlen();
            var rand = new Random();
            ArrayList liste = new ArrayList();



        while (liste.Count < 5)
        {
            zahl.zufallsZahl = rand.Next(1, 51);
            
            if (!liste.Contains(zahl.zufallsZahl))
            {
                liste.Add(zahl.zufallsZahl);
                liste.Sort();
            }

        }
        Console.WriteLine("Tipp");
        foreach (object a in liste)
        {
            
            Console.Write(a + ", ");
        }

        }
    }
}


