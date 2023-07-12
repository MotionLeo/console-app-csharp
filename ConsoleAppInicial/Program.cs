using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace ConsoleAppInicial
{
    class Program
    {
        static void Main(string[] args)
        {
            var cachorro = new Cachorro();
            cachorro.Idade = 1;
            Console.WriteLine(cachorro.Idade);
            /*
            //Menu.Criar();

            Console.WriteLine("===============Cadastro de Cliente===============");
            Cliente c = new Cliente();
            c.Nome = "Cliente";
            c.Telefone = "45678912";
            c.Cpf = "888666222";
            c.Gravar();
            foreach (Base cl in c.Ler())
            {
                Console.WriteLine(cl.Nome);
                Console.WriteLine(cl.Telefone);
                Console.WriteLine(cl.Cpf);
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine("===============Cadastro de Usuário===============");
            Usuario u = new Usuario();
            u.Nome = "Usuário";
            u.Telefone = "12987745";
            u.Cpf = "1144778899";
            u.Gravar();
            foreach(Base us in u.Ler())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.Cpf);
                Console.WriteLine("--------------------------");
            }
            */
        }
    }
}
