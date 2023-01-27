using Aula3_OOP.TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class TesteSomaVogais
    {
        [Theory]
        [InlineData("ABCDEFG", 2)]
        [InlineData("BCD", 0)]
        [InlineData("aeiou", 5)]
        [InlineData("Áébcd", 2)]
        public void TestaSomaVogais(string texto, int somaEsperada)
        {
            var soma = SomaVogais.Soma(texto);
            Assert.Equal(somaEsperada, soma);            
        }
    }
}
