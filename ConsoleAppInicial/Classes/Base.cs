using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Base : IPessoa
    {
        public Base() { }
        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        public string Nome;
        public string Telefone;
        public string Cpf;

        public void SetNome(string nome) { this.Nome = nome;  }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCpf(string cpf) { this.Cpf = cpf; }

        public virtual void Gravar()
        {

            var listaBase = this.Ler();
            listaBase.Add(this);
            
            StreamWriter r = new StreamWriter(DiretorioComArquivo());
            r.WriteLine("nome;telefone;cpf;");
            foreach (Base b in listaBase)
            {
                var novaLinha = b.Nome + ";" + b.Telefone + ";" + b.Cpf + ";";
                r.WriteLine(novaLinha);
            }
            r.Close();
            
        }
        private string DiretorioComArquivo()
        {
            return ConfigurationManager.AppSettings["Bd"] + this.GetType().Name + ".txt";
        }

        public List<IPessoa> Ler()
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
                        var based = (IPessoa)Activator.CreateInstance(this.GetType());
                        based.SetNome(baseArquivo[0]);
                        based.SetTelefone(baseArquivo[1]);
                        based.SetCpf(baseArquivo[2]);
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
