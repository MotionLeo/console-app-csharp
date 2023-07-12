using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    abstract class Animal
    {
        public string Coleira;
        public string Pelo;
        public string Olhos;

        public abstract void Latir();
        public string Correr()
        {
            return "Animal está correndo";
        }
    }
}
