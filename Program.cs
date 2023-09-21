using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targa
{
    internal class Program
    {
        static void Main(string[] args) //Mattia Gasparetto 4°E
        {
            string targa;
            int valoreFinale = 0;
            bool controllo = true;
            do
            {
                if (!controllo)
                {
                    Console.WriteLine("Inserisci una targa nel formato indicato.");
                }
                Console.WriteLine("Inserisci una targa nel formato LLCCCLL (L = lettera alfabeto inglese C = cifra in base 10):");
                targa = Console.ReadLine().ToUpper();
                int i = 0;
                do
                {
                    if (((i < 2 || i > 4) && (targa[i] < 65 || targa[i] > 90)) || ((i > 1 && i < 5) && (targa[i] < 48 || targa[i] > 57)))
                    {
                        controllo = !controllo;
                    }
                    i++;
                } while (i < targa.Length);
            } while (!controllo);

            for (int i = 0; i < targa.Length; i++)
            {
                if (i < 2)
                {
                    valoreFinale = valoreFinale * 26 + ((int)targa[i] - (int)'A');
                }
                else if (i >= 2 && i < 5)
                {
                    valoreFinale = valoreFinale * 10 + ((int)targa[i] - (int)'0');
                }
                else if (i >= 5 && i < 7)
                {
                    valoreFinale = valoreFinale * 26 + ((int)targa[i] - (int)'A');
                }
            }
            Console.WriteLine($"Il valore della targa {targa} è {valoreFinale}");
            Console.ReadLine();
        }
    }
}
