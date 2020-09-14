using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUPaplicacao
{
    class Program
    {
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULAR_MEDIA= 3;
        public const int SAIR = 4;
        static void Main(string[] args)
        {
            while (true)
            {
                System.DateTime data = new System.DateTime();
                String MsgMenu = "\t\tEscolha uma opção abaixo:" +
                    "\n\n\t\t1 - Ler arquivos .txt" +
                    "\n\n\t\t2 - Tabuada" +
                    "\n\n\t\t3 - Calcular média" +
                    "\n\n\t\t4 - Sair" +
                    "\n\n\t\tdatetime = " + data;


                Console.WriteLine(MsgMenu);
                int option = int.Parse(Console.ReadLine());

                if (option == 4)
                {
                    break;
                }
                
                
                switch (option)
                {
                    case 1:
                        LerArquivo.LerArquivos(1);
                        break;
                    case 2:
                        Tabuada tb = new Tabuada();
                        tb.ExecutarTabuada();
                        
                        break;
                    case 3:
                        CalculaMedia.ExecutarCalculaMedia();

                        break;
                    default:
                        Console.WriteLine("Digite uma opção valida!!");                        
                        break;
                    
                }
            }
        }
    }
}
