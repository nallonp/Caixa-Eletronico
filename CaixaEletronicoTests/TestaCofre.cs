using CaixaEletronico;
using CaixaEletronico.Tesouro;
using System;
using System.Collections.Generic;
using Xunit;

namespace CaixaEletronicoTest
{
    public class TestaCofre
    {
        [Fact]
        public void Retirar()
        {
            var cofre = new Cofre(new Dictionary<ENota, uint>());
            cofre.Armazenar(ENota.CINQUENTA, 2);
            //Assert.Null(cofre.Retirar(80));
            Assert.Throws<ArgumentException>(()=>cofre.Retirar(80));
        }
    }
}
