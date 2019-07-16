using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public class Registro : IRegistro
    {
        public DateTime Date { get; private set; }

        public ENota Nota { get; private set; }

        public uint Quantidade { get; private set; }

        public ETipoTransacao TipoTransacao { get; private set; }

        public Registro(ENota n, uint q, ETipoTransacao t)
        {
            Date = DateTime.UtcNow;
            Nota = n;
            Quantidade = q;
            TipoTransacao = t;
        }
    }
}
