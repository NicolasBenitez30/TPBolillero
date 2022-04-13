using System;
using System.Collections.Generic;
namespace TPBolillero.Core
{
    public class Bolillero
    {
        public List<byte> Adentro { get; set; }
        public List<byte> Afuera { get; set; }
        public IAzar Azar { get; set; }

        public Bolillero(IAzar azar)
        {
            Adentro = new List<byte>();
            Afuera = new List<byte>();
            Azar = azar;
        }
        public Bolillero(IAzar azar, byte numeros) 
            => CrearBolillas(numeros);
        private void CrearBolillas(byte numeros)
        {
            for (int i = 0; i < Adentro.Count; i++)
                Adentro.Add(numeros);
        }
        public void ReIngresar()
        {
            Afuera.AddRange(Adentro);
            Afuera.Clear();
        }
        public byte SacarBolillas()
        {
            var bol = Azar.SacarBolilla(Adentro);
            Afuera.Add(bol);
            Adentro.Remove(bol);
            return bol;
        }

        //public bool Jugar(List<byte>)
        //public JugarN(List<byte>) : long
    }
}