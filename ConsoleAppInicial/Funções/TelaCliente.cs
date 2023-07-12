using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("--------------Cadastro de cliente--------------");

            while (true)
            {
                string mensagem = @"Digite uma das opções abaixo:
                    0 - Sair do cadastro;
                    1 - Para cadastrar clientes;
                    2 - Para listar clientes;
                    ";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0) break;

                else if (valor == 1)
                {
                    var cliente = new Cliente();

                    Console.WriteLine("Digite o nome do cliente: ");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do cliente: ");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do cliente: ");
                    cliente.Cpf = Console.ReadLine();

                    cliente.Gravar();
                }

                else if (valor == 2)
                {
                    var clientes = new Cliente().Ler();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine(c.Nome);
                        Console.WriteLine(c.Telefone);
                        Console.WriteLine(c.Cpf);
                        Console.WriteLine("-------------------");

                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
