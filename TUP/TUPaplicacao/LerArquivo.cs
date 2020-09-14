using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUPaplicacao
{
    class LerArquivo
    {
        public static void LerArquivos(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivo\arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    Console.WriteLine("\n=======================================\n" + "Arquivo: " + arquivoComCaminho + "\n=======================================\n");
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                    Console.WriteLine("=============================================================");
                }
            }
            string arquivoComCaminho2 = @"C:\arquivo\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivos(numeroArquivo + 1);
            }

        }
    }
}
