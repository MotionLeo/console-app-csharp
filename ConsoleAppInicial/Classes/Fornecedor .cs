using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Fornecedor : Base
    {
        public Fornecedor() { }

        public string Cnpj;
        /// <summary>
        /// Construtor de classe (usando overload)
        /// </summary>
        /// <param name="nome">Para preencher o nome do objeto</param>

        public Fornecedor(string nome)
        {
            this.Nome = nome;
        }
        /// <summary>
        /// Construtor da classe com todos os parâmetros (usando overload)
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>

        public Fornecedor(string nome, string telefone, string cpf, string cnpj)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Cnpj = cnpj;
        }

        public override void Gravar()
        {

            var listaBase = this.Ler();
            listaBase.Add(this);

            StreamWriter r = new StreamWriter(DiretorioComArquivo());
            r.WriteLine("nome;telefone;cpf;cnpj");
            foreach (Fornecedor b in listaBase)
            {
                var novaLinha = b.Nome + ";" + b.Telefone + ";" + b.Cpf + ";" + b.Cnpj + ";";
                r.WriteLine(novaLinha);
            }
            r.Close();

        }

        public override List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(DiretorioComArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(DiretorioComArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');
                        var based = (Fornecedor)Activator.CreateInstance(this.GetType());
                        based.SetNome(baseArquivo[0]);
                        based.SetTelefone(baseArquivo[1]);
                        based.SetCpf(baseArquivo[2]);
                        based.Cnpj = baseArquivo[3];

                        /*var based = new Base
                        {
                            Nome = baseArquivo[0],
                            Telefone = baseArquivo[1],
                            Cpf = baseArquivo[2]
                        };*/


                        dados.Add(based);
                    }
                }
            }
            return dados;
        }
    }
}
