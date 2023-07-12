using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente : Base
    {
        /// <summary>
        /// Construtor sem parâmetro
        /// </summary>
        public Cliente() { }

        /// <summary>
        /// Construtor de classe (usando overload)
        /// </summary>
        /// <param name="nome">Para preencher o nome do objeto</param>

        public Cliente(string nome)
        {
            this.Nome = nome;
        }
        /// <summary>
        /// Construtor da classe com todos os parâmetros (usando overload)
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>

        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

    }
}
