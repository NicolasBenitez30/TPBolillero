using System;
using System.Collections.Generic;
namespace TPBolillero.Core
{
    public class Aleatorio : IAzar
    {
        private Random r = new Random();
        public byte SacarBolilla(List<byte> numeros)
        {
            var indiceAleatorio = Convert.ToByte(r.Next(0, numeros.Count));
            return numeros[indiceAleatorio];
        }
    }
}