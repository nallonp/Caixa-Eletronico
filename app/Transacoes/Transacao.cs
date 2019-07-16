using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Transacoes
{
    public class Transacao : ITransacao
    {
        public ENota Nota { get; private set; }

        public uint Quantidade { get; private set; }

        public ETipoTransacao TipoTransacao { get; private set; }
        public Transacao(ENota nota, uint quantidade, ETipoTransacao tipo)
        {
            Nota = nota;
            Quantidade = quantidade;
        }
    }
}
