using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Relatorios
{
    public class Relatorio
    {
        public List<RegistroDeTransacao> log { get; private set; }

        public void AdicionarRegistro(RegistroDeTransacao registro)
        {
            log.Add(registro);
        }
    }
}
