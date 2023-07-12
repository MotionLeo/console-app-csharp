using Funções;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;

        public static void Criar()
        {
            while (true)
            {
                string mensagem = @"Olá usuário, bem vindo ao programa
                    Aplicação Console Final
                    Digite uma das opções abaixo:
                    0 - Sair do programa;
                    1 - Para ler arquivos;
                    2 - Para executar a tabuada;
                    3 - Calcular média de Alunos;
                    4 - Cadastrar clientes;
                    ";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA) break;

                else if (valor == TABUADA)
                {
                    TelaTabuada.Chamar();
                    Console.WriteLine("---------------------------------------");
                }

                else if(valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                    Console.WriteLine("---------------------------------------");
                }
            }

        }
    }
}
