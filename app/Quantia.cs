using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public class Quantia : IQuantia
    {
        public ENota Nota { get; private set; }

        public uint Quantidade { get; private set; }

        public Quantia(ENota n, uint q)
        {
            Nota = n;
            Quantidade = q;
        }
    }
}
