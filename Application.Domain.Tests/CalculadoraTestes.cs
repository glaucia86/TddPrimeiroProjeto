using NUnit.Framework;

namespace Application.Domain.Tests
{
    [TestFixture]
    public class CalculadoraTestes
    {
        [Test]
        public void DevoSomarDoisNumeros()
        {
            var sut = new Calculadora();

            var result = sut.Somar(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void DevoMultiplicarDoisNumeros()
        {
            var sut = new Calculadora();

            var result = sut.Multiplicar(2,10);

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void DevoDiminuirDoisNumeros()
        {
            var sut = new Calculadora();

            var result = sut.Diminuir(10, 6);

            Assert.That(result, Is.EqualTo(4));
        }

        //Esse teste aqui vai falhar!! Propositalmente!! ;)
        [Test]
        public void DevoDividirDoisNumeros()
        {
            var sut = new Calculadora();

            var result = sut.Dividir(10, 5);

            Assert.That(result, Is.EqualTo(4));
        }
    }
}
