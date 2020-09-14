using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUPaplicacao
{
    class Tabuada
    {
        
        public void ExecutarTabuada()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-Tabuada=-=-=-=-=-=-=-=-=-=-\n\n\t\tDigite um numero");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
               Console.WriteLine("\t\t" + numero + " X " + i + " = " + i*numero);
            }
            
        }
    }
}
