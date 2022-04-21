using Xunit;
using System.Collections.Generic;
using TPBolillero.Core;

namespace TPBolillero.Test
{
    public class BolilleroTest
    {
        public Bolillero Bolillero { get; set; }
        static IAzar _primero = new Primera();
        public BolilleroTest()
        {
            Bolillero = new Bolillero(_primero, 10);
        }
        [Fact]
        public void TestSacarBolilla()
        {
            var primera = Bolillero.SacarBolilla();
            var contador = Bolillero.Adentro.Count;
            var afuera = Bolillero.Afuera.Count;
            Assert.Equal(0, primera);
            Assert.Equal(9, contador);
            Assert.Equal(1, afuera);
        }
        [Fact]
        public void TestReIngresar()
        {
            Bolillero.SacarBolilla();
            Bolillero.ReIngresar();
            var contadorDentro = Bolillero.Adentro.Count;
            var contadorAfuera = Bolillero.Afuera.Count;
            Assert.Equal(10, contadorDentro);
            Assert.Equal(0, contadorAfuera);
        }

        [Fact]
        public void TestJugarGana()
        {
            List<byte> lista1 = new List<byte>{0, 1};
            List<byte> lista2 = new List<byte>{0, 1, 2};
            List<byte> lista3 = new List<byte>{0, 1, 2, 3};
            Assert.True(Bolillero.Jugar(lista1));
            
            Bolillero = new Bolillero(_primero, 10);
            Assert.True(Bolillero.Jugar(lista2));

            Bolillero = new Bolillero(_primero, 10);
            Assert.True(Bolillero.Jugar(lista3));
        }
        [Fact]
        public void TestJugarPierde()
        {            
            List<byte> lista1 = new List<byte>{1, 2};
            List<byte> lista2 = new List<byte>{1, 2, 3};
            List<byte> lista3 = new List<byte>{1, 2, 3, 4};
            Assert.False(Bolillero.Jugar(lista1));

            Bolillero = new Bolillero(_primero, 10);
            Assert.False(Bolillero.Jugar(lista2));

            Bolillero = new Bolillero(_primero, 10);
            Assert.False(Bolillero.Jugar(lista3));
        }
        [Fact]
        public void TestGanarNVeces()
        {
            List<byte> lista1 = new List<byte>{0, 1};
            var veces = Bolillero.JugarN(lista1, 1);
            Assert.Equal(1, veces);
        }
    }
}