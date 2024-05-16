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
            int zf = 0;
            var rand = new Random();
            ArrayList liste = new ArrayList();
      
            for(int i=0;i<5;i++)
            {
                zahl.zufallsZahl = rand.Next(1, 51);
                Console.WriteLine(zahl.zufallsZahl);
                if(!liste.Contains(zahl.zufallsZahl))
                {
                    liste.Add(liste);
                }
                
            }
           
            foreach(int a in liste)
            {
                Console.WriteLine(a);
            }
            
        }
    }      
}


