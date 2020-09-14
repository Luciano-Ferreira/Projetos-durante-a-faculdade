using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUPaplicacao
{
    class CalculaMedia
    {
        
        public static void ExecutarCalculaMedia()
        {
            int np1, np2, pim, media;

            Console.WriteLine("\n\tDigite a nota da primeira prova (np1):\n\t");
            np1 = Console.Read();
            Console.WriteLine("\n\tDigite a nota da segunda prova (np2):\n\t");
            np2 = Console.Read();
            Console.WriteLine("\n\tDigite a nota do Projeto Integrado Multidisciplinar (PIM):\n\t");
            pim = Console.Read();

            media = ((np1 / 4) + (np2 / 4)) * (pim/ 2);

            Console.WriteLine("Sua media final é " + media + "\n\tNP1: " + np1 + "\n\tNP2: " + np2 + "\n\tPIM: " + pim);

            
        }
        



    }
}
