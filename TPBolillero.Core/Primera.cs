using System;
using System.Collections.Generic;
namespace TPBolillero.Core
{
    public class Primera : IAzar
    {
        public byte SacarBolilla(List<byte> numeros) => numeros[0];
    }
}