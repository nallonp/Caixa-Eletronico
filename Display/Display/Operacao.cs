using System;
using System.Collections.Generic;
using System.Text;

namespace view.Display
{
    public class Operacao
    {
        public String Codigo { get; private set; }
        public String Descricao { get; private set; }
        public Operacao(String codigo, String descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}
