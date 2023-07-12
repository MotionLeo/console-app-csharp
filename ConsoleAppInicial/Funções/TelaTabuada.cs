using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções
{
    class TelaTabuada
    {
        public static void Chamar()
        {
            Console.WriteLine("--------------Tabuada--------------");

            Console.WriteLine("Digite o número que deseja multiplicar: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + numero*i);
            }
        }
    }
}
