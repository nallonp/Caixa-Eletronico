using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public interface IRegistro
    {
        DateTime Date { get; }
        ENota Nota { get; }
        uint Quantidade { get; }
        ETipoTransacao TipoTransacao { get;}

    }
}
