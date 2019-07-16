using CaixaEletronico.Transacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaEletronico.Tesouro
{
    public class Cofre
    {
        public IDictionary<ENota, uint> _Reservas { get; private set; }

        public Cofre(Dictionary<ENota, uint> reservas)
        {
            _Reservas = reservas;
        }

        public void Armazenar(ENota nota, uint quantidade)
        {
            if (_Reservas.ContainsKey(nota))
                _Reservas[nota] += quantidade;
            else
            {
                _Reservas.Add(nota, quantidade);
                _Reservas = _Reservas.OrderByDescending(p => p.Key).ToDictionary(p => p.Key, p => p.Value);
            }
        }

        public void Retirar(int retirada)
        {
            throw new NotImplementedException();
        }

        public void Retirar(uint valor)
        {
            var retirada = new Dictionary<ENota, uint>();
            foreach (var nota in _Reservas)
            {
                while (valor >= (uint)nota.Key)
                {
                    if (retirada.ContainsKey(nota.Key))
                        retirada[nota.Key]++;
                    else
                        retirada.Add(nota.Key, 1);
                    valor -= (uint)nota.Key;
                    if (nota.Value == retirada[nota.Key])
                        break;
                }
            }
            if (valor == 0)
                Retirar(retirada);
            else
                throw new ArgumentException("Não há notas necessárias para processar esse saque.");
        }
        private void Retirar(Dictionary<ENota, uint> retirada)
        {
            foreach (var item in retirada)
            {
                _Reservas[item.Key] -= item.Value;
                if (_Reservas[item.Key] == 0)
                    _Reservas.Remove(item.Key);
            }
        }
    }
}
