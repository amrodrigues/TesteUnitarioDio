using Calculadora.Services;



namespace CalculadoraTeste
{
    public class CalculadoraTests
    {
        private CalculadoraImp _calc;

        public CalculadoraTests()
        {
            _calc = new CalculadoraImp();

        }


        [Fact]
        public void DeveSomar5Com10eRetornar15()
        {
            //Arrange
            int num1 = 5;
            int num2 = 10;

            //Act
            int resultado = _calc.Somar(num1, num2);


            // Assert

            Assert.Equal(15, resultado);

        }

        [Fact]
        public void DeveSomar10Com10eRetornar20()
        {
            //Arrange
            int num1 = 10;
            int num2 = 10;

            //Act
            int resultado = _calc.Somar(num1, num2);


            // Assert

            Assert.Equal(20, resultado);

        }

        [Fact]
        public void DeveVerificarSe4EhParERetornarVerdadeiro()
        {
            //Arrange
            int num1 = 4;
           
            //Act
            bool resultado = _calc.EhPar(num1);


            // Assert

            Assert.True(resultado);

        }



        //[Theory]
        //[InlineData(2)]
        //[InlineData(6)]
        //[InlineData(8)]
        //[InlineData(10)]
        //public void DeveVerificarSeOsNumerosSaoParERetornarVerdadeiro(int numero)
        //{


        //    //Act
        //    bool resultado = _calc.EhPar(numero);


        //    // Assert

        //    Assert.True(resultado);

        //}

        //Refatorando o teste acima

        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8, 10 })]
        public void DeveVerificarSeOsNumerosSaoParERetornarVerdadeiro(int[] numeros)
        {

            Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));

        }
    }
}

