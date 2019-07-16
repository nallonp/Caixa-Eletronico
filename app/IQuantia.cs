using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public interface IQuantia
    {
        ENota Nota { get; }
        uint Quantidade { get; }
    }
}
