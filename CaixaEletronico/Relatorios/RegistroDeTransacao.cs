using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Relatorios
{
    public class RegistroDeTransacao
    {
        public DateTime Date { get; private set; }

        public ENota Nota { get; private set; }

        public uint Quantidade { get; private set; }
        public ETipoDeTransacao Transacao { get; private set; }
        public RegistroDeTransacao(DateTime data, ENota nota, uint quantidade, ETipoDeTransacao transacao)
        {
            Date = data;
            Nota = nota;
            Quantidade = quantidade;
            Transacao = transacao;
        }
    }
}
