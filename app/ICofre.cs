using CaixaEletronico.Transacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public interface ICofre
    {
        void Armazenar(ENota nota, uint numero);
        void Retirar(ENota nota, uint numero);
        void RealizarTransacao(ITransacao transacao);
        int RetornarSaldo();
    }
}
