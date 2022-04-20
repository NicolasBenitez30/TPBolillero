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
            for (int i = 0; i < numeros -1; i++)
                Adentro.Add(numeros);
        }
        public void ReIngresar()
        {
            Afuera.AddRange(Adentro);
            Afuera.Clear();
        }
        public byte SacarBolilla()
        {
            var bol = Azar.SacarBolilla(Adentro);
            Afuera.Add(bol);
            Adentro.Remove(bol);
            return bol;
        }

        public bool Jugar(List<byte> numeros)
            => numeros.TrueForAll(n => n == SacarBolilla());

        public long JugarN(List<byte> numeros, long veces)
        {
            long cuenta = 0;
            for(long i = 0; i < veces; i++)
            {
                if(Jugar(numeros))
                    cuenta++;                
            }
            return cuenta;
        }
    }
}