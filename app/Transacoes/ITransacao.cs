using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Transacoes
{
    public interface ITransacao
    {
        ENota Nota { get; }
        uint Quantidade { get; }
        ETipoTransacao TipoTransacao { get; }
    }
}
