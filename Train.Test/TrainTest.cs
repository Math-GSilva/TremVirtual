namespace Train.Test
{
    public class TrainTest
    {
        [Theory]
        [InlineData(new string[] { "DIREITA" }, 1)]
        [InlineData(new string[] { "ESQUERDA" }, 0)]
        [InlineData(new string[] { "DIREITA", "DIREITA", "DIREITA" }, 3)]
        public void Trem_DeveMoverNaDirecaoCorreta(string[] comandos, int posicaoEsperada)
        {
            var trem = new Train.App.Train();
            trem.DoTask(new List<string>(comandos));

            Assert.Equal(posicaoEsperada, trem.Position);
        }

        [Theory]
        [InlineData(new string[] { "DIREITA", "direita", "ESQUERDA" }, 0)]
        [InlineData(new string[] { "esquerda", "DIREITA", "DIREITA", "DIREITA" }, 3)]
        public void Trem_DeveIgnorarComandosInvalidos(string[] comandos, int posicaoEsperada)
        {
            var trem = new Train.App.Train();
            trem.DoTask(new List<string>(comandos));

            Assert.Equal(posicaoEsperada, trem.Position);
        }

        [Theory]
        [InlineData(new string[] { "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA",
                                   "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA",
                                   "DIREITA" }, 20)]
        public void Trem_NaoDeveFazerMaisDe20MovimentosConsecutivosNaMesmaDirecao(string[] comandos, int posicaoEsperada)
        {
            var trem = new Train.App.Train();
            trem.DoTask(new List<string>(comandos));

            Assert.Equal(posicaoEsperada, trem.Position);
        }

        [Theory]
        [InlineData(new string[] { "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA",
                                   "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA", "DIREITA",
                                   "DIREITA", "ESQUERDA", "ESQUERDA", "ESQUERDA", "ESQUERDA", "ESQUERDA", "ESQUERDA", "ESQUERDA", "ESQUERDA", "ESQUERDA", "ESQUERDA" }, 20)]
        public void Trem_DeveContinuarMovendoApos20MovimentosConsecutivosNaOutraDirecao(string[] comandos, int posicaoEsperada)
        {
            var trem = new Train.App.Train();
            trem.DoTask(new List<string>(comandos));

            Assert.Equal(posicaoEsperada, trem.Position);
        }

        [Theory]
        [InlineData(new string[] { }, 0)]
        public void Trem_DeveManterAPosicaoInicialSemMovimento(string[] comandos, int posicaoEsperada)
        {
            var trem = new Train.App.Train();
            trem.DoTask(new List<string>(comandos));

            Assert.Equal(posicaoEsperada, trem.Position);
        }
    }
}
