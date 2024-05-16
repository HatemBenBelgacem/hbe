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



            for (int i = 0; i < 5; i++)
            {
                zahl.zufallsZahl = rand.Next(1, 51);
                
                if (!liste.Contains(zahl.zufallsZahl))
                {
                    liste.Add(zahl.zufallsZahl);
                }

            }

        foreach (object a in liste)
        {
            Console.Write(a + ", ");
        }

        }
    }
}


