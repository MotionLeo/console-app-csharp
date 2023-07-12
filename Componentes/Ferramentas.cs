using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Ferramentas
    {
        internal string metodoSomenteParaMeuAssembly()
        {
            return "Este metódo só pode ser acessado dentro deste assembly componente";
        }
        public string metodoParaTodosQueUtilizarOAssembly()
        {
            return "Este metódo é para todos";
        }
    }
}
