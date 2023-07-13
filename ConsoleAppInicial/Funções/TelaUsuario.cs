using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("--------------Cadastro de Usuário--------------");

            while (true)
            {
                string mensagem = @"Digite uma das opções abaixo:
                    0 - Sair do cadastro;
                    1 - Para cadastrar Usuários;
                    2 - Para listar Usuários;
                    ";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0) break;

                else if (valor == 1)
                {
                    var usuario = new Usuario();

                    Console.WriteLine("Digite o nome do Usuário: ");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Usuário: ");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Usuário: ");
                    usuario.Cpf = Console.ReadLine();

                    usuario.Gravar();
                }

                else if (valor == 2)
                {
                    var Usuarios = new Usuario().Ler();
                    foreach (Usuario c in Usuarios)
                    {
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Nome: "+ c.Nome);
                        Console.WriteLine("Telefone: "+ c.Telefone);
                        Console.WriteLine("CPF: "+ c.Cpf);
                        Console.WriteLine("-------------------");

                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
