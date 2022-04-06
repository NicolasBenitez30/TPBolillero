using System;
using System.Collections.Generic;
namespace TPBolillero.Core
{
    public class Bolillero
    {
        public List<byte> Adentro { get; set; }
        public List<byte> Afuera { get; set;}
        public IAzar Azar { get; set; }

        public Bolillero()
        {
            Adentro = new List<byte>();
            Afuera = new List<byte>();
            Azar = new IAzar();
        }
        //public void Bolillero(byte)
        //private void CrearBolillas(byte)
        //public ReIngresar()
        //public SacarBolillas : byte
        //public bool Jugar(List<byte>)
        //public JugarN(List<byte>) : long
    }
}