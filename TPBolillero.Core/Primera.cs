using System;
using System.Collections.Generic;
namespace TPBolillero.Core
{
    public class Primera : IAzar
    {
        public IAzar Clonar() => this;

        public byte SacarBolilla(List<byte> numeros) => numeros[0];
    }
}