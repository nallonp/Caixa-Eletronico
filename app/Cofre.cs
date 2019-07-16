using CaixaEletronico.Transacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public class Cofre
    {
        private IDictionary<ENota, uint> _Reservas { get; set; }

        public void Armazenar(ENota nota, uint quantidade)
        {
            if (_Reservas.ContainsKey(nota))
                _Reservas[nota] += quantidade;
            else
                _Reservas.Add(nota, quantidade);
        }

        public void Retirar(ENota nota, uint quantidade)
        {
            if (_Reservas.ContainsKey(nota) && _Reservas[nota] < quantidade)
                _Reservas[nota] -= quantidade;
            else
                throw new ArgumentException("Quantidade insuficiente de notas.");
        }

        public bool EhPossivelSacar(uint montante)
        {
            var saldo = 0;
            foreach (var i in _Reservas)
            {
                saldo += ((int)i.Key * (int)i.Value);
            }
            return saldo >= montante;
        }
    }
}
