using System;
using System.Collections.Generic;
using System.Collections;
namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            //LISTE infiniti elementi con dato coerente a differenza di arrayList
            List<int> prova = new List<int>() {1,2, 3, 4, 5};
            prova.Add(5);
            int[] prova2 = { 1, 2 };
            prova.AddRange(prova2);
            prova.Insert(1, 2); //all'indice 1 aggiunge 2
            prova[0] = 55;
            prova.Remove(55);
            prova.RemoveAt(0); //posizione
            prova.RemoveRange(0, 3); //rimuovi dalla posizione 0 a 3
            prova.Contains(0); //contiene 0 true o false

            foreach (int items in prova)
            {
                Console.WriteLine(items);   
            }
            for (int i = 0; i <  prova.Count; i++)
            {
                Console.WriteLine(prova[i]);
            }
        }
    }
}

