using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollections
{
    class Program
    {
        static int Calcular()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        private static void LerArquivos(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivo\arq"+ numeroArquivo +".txt";
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                    Console.WriteLine("=============================================================");
                }
            }
            string arquivoComCaminho2 = @"C:\arquivo\arq" + (numeroArquivo + 1)+ ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivos(numeroArquivo + 1);
            }
            
        }

        public const int SAIDA_PROGRAMA = 1;


        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair.");
                int valor = int.Parse(Console.ReadLine());
                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
            }
            LerArquivos(1);

            Console.Write("=========================================  -- Arrays  --  ================================================\r\n");
            String[] a = new String[4];
            a[1] = "Luciano1";
            a[0] = "jair";
            a[2] = "rato";
            a[3] = "Luciano2";

            foreach (String nome in a)
            {
                Console.WriteLine("Nome:" + nome);
            }
            //semelhança com like do mysql
            // mas tem case sensitivy
            if (Array.Exists(a, e => e.IndexOf("Luciano")!=-1))
            {
                Console.WriteLine("membro com nome semelhante existente no array");
            }
            else
            {
                Console.WriteLine("nenhum membro com nome semelhante existente no array");

            }

            if (Array.Exists(a, e=>e == "Luciano"))
            {
                Console.WriteLine("membro existente");
            }
            else
            {
                Console.WriteLine("membro não existente");

            }

            int size = a.Length;

            Console.WriteLine("=========================================  --  Collections  --  ================================================");

            List<string> lista = new List<string>();
            lista.Add("Luciano");
            lista.Add("Erica");
            lista.Add("Ana");
            lista.Add("Outlaw");

            int size_list = lista.Count;


            String z;
            z = Console.ReadLine();

            

            foreach (String nome in lista)
            {
                Console.WriteLine("Nome:" + nome);
            }

            if (lista.Exists(e => e == z))
            {
                Console.WriteLine(z + " está em nossa lista/r/nNossa lista tem " + size_list + " membros");
            }
            else
            {
                Console.WriteLine(z + " não está em nossa lista\r\nNossa lista tem "+ size_list + " membros");
            }



            Console.Read();

        }
    }
}
