using System;
using System.Collections.Generic;
namespace TPBolillero.Core
{
    public interface IAzar
    {
        byte SacarBolilla(List<byte> numeros);
    }
}