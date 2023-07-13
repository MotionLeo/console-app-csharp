using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("--------------Cadastro de Fornecedor--------------");

            while (true)
            {
                string mensagem = @"Digite uma das opções abaixo:
                    0 - Sair do cadastro;
                    1 - Para cadastrar Fornecedor;
                    2 - Para listar Fornecedores;
                    ";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0) break;

                else if (valor == 1)
                {
                    var fornecedor = new Fornecedor();

                    Console.WriteLine("Digite o CNPJ do Fornecedor: ");
                    fornecedor.Cnpj = Console.ReadLine();

                    Console.WriteLine("Digite o nome do Fornecedor: ");
                    fornecedor.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Fornecedor: ");
                    fornecedor.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do gerente: ");
                    fornecedor.Cpf = Console.ReadLine();

                    fornecedor.Gravar();
                }

                else if (valor == 2)
                {
                    var fornecedores = new Fornecedor().Ler();
                    foreach (Fornecedor f in fornecedores)
                    {
                        Console.WriteLine("-------------------");
                        Console.WriteLine("CNPJ: " + f.Cnpj);
                        Console.WriteLine("Nome: "+ f.Nome);
                        Console.WriteLine("Telefone: "+ f.Telefone);
                        Console.WriteLine("CPF do gerente: "+ f.Cpf);
                        Console.WriteLine("-------------------");

                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
