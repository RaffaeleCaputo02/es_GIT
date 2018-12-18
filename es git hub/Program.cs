using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_git_hub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buongiorno");
            Console.ReadLine();
            int num1, num2;
            int prodotto=0;
            Console.WriteLine("Inserisci il primo numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            prodotto = num1 * num2;
            Console.WriteLine($"Il prodotto è {prodotto}");

            int resto = 0;
            resto = prodotto % 2;
            if(resto==0)
            {
                Console.WriteLine("Il prodotto è pari");
            }
            else
            {
                Console.WriteLine("Il numero è dispari");
            }

        }
    }
}
