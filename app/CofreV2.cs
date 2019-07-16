using CaixaEletronico.Transacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public class CofreV2 : ICofre
    {
        public List<IRegistro> Relatorios { get; private set; }
        private IDictionary<ENota, uint> _Reservas { get; set; }

        public void RealizarTransacao(ITransacao t)
        {
            throw new NotImplementedException();
        }

        public void Armazenar(ENota nota, uint quantidade)
        {
            if (_Reservas.ContainsKey(nota))
                _Reservas[nota] += quantidade;
            else
                _Reservas.Add(nota, quantidade);
            Relatorios.Add(new Registro(nota, quantidade, ETipoTransacao.DEPOSITO));
        }


        public void Retirar(ENota nota, uint quantidade)
        {
            if (_Reservas.ContainsKey(nota))
                _Reservas[nota] -= quantidade;
            else
                _Reservas.Add(nota, quantidade);
            Relatorios.Add(new Registro(nota, quantidade, ETipoTransacao.RETIRADA));
        }

        public int RetornarSaldo()
        {
            var saldo = 0;
            foreach (var i in _Reservas)
            {
                saldo += ((int)i.Key * (int)i.Value);
            }
            return saldo;
        }
    }
}
