using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public class RegistroDeTransacao
    {
        public DateTime Date { get; private set; }

        public ENota Nota { get; private set; }

        public uint Quantidade { get; private set; }
        public RegistroDeTransacao(ENota n, uint q)
        {
            Date = DateTime.UtcNow;
            Nota = n;
            Quantidade = q;
        }
    }
}
