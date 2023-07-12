using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"];
        }
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = caminhoArquivo() + "arq" + numeroArquivo + ".txt";
            Console.WriteLine("========= Lendo arquivo =========\n" + arquivoComCaminho + "\n==================");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
        }
    }
}
