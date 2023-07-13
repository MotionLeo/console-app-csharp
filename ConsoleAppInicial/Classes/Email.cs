using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Email
    {
        private Email() { }

        private static Email instancia;
        public string Origem;
        public string Destino;
        public string Corpo;
        public string Assunto;

        public void EnviarEmail()
        {
            Console.WriteLine("Enviando email para: "+ Destino + "\nCom o assunto: " + Assunto + "\nCorpo: " +Corpo);
        }
        public static Email Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Email();
                }
                return instancia;
            }
        }
    }
}
