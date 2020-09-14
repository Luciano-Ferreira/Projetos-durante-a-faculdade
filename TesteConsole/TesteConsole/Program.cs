using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingresso ing1 = new Ingresso();
            Console.WriteLine("1 - Para normal \n2 - Para VIP");
            int opcao1 = Convert.ToInt32(Console.ReadLine());
            if (opcao1 == 1)
            {
                Console.WriteLine("Seu ingresso é do tipo Normal");

            }
            else if (opcao1 == 2)
            {
                Console.WriteLine("Seu ingresso é do tipo VIP");


                Console.WriteLine("\n\n\n1 - Para camarote superior \n2 - para inferior \n3 - Voltar");
                int opcao2 = Convert.ToInt32(Console.ReadLine());
                switch (opcao2)
                {
                    case 1:
                        Console.WriteLine("Seu vip é camarote superior");
                        break;
                    case 2:
                        Console.WriteLine("Seu vip é camarote inferior");
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção valida");
                        break;


                }
                //if (opcao2==1) {
                //    Console.WriteLine("Seu vip é camarote superior");
                //}
                //else if(opcao2==2){
                //    Console.WriteLine("Seu vip é camarote inferior");
                //}
                //else if(opcao2==3) {
                //    return;
                //}
                //else {
                //    Console.WriteLine("Escolha uma opção valida");
                //}
            }
            else
            {
                Console.WriteLine("Escolha uma opção valida");
            }
            
        }
    }
}
