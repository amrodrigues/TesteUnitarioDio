using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ValidacoesStringTests
    {

        private ValidacoesStrings _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesStrings();
        }

        [Fact]
        public void DeveContarCaracterresEmOlaERetornar3()
        {
            //Arrangs

            string texto = "Ola";
            
            //Act
            int resultado = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resultado);
        }
    }
}
