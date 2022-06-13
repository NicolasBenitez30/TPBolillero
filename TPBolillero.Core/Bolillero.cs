﻿using System;
using System.Collections.Generic;
namespace TPBolillero.Core
{
    public class Bolillero : ICloneable
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
        public Bolillero(IAzar azar, byte numeros) : this(azar)
            => CrearBolillas(numeros);


        private Bolillero(Bolillero original)
        {
            Adentro = new(original.Adentro);
            Afuera = new(original.Afuera);
            Azar = original.Azar.Clonar();
        }
        private void CrearBolillas(byte numeros)
        {
            for (byte i = 0; i < numeros; i++)
                Adentro.Add(i);
        }
        public void ReIngresar()
        {
            Adentro.AddRange(Afuera);
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
            for (long i = 0; i < veces; i++)
            {
                ReIngresar();
                if (Jugar(numeros))
                    cuenta++;
            }
            return cuenta;
        }

        public object Clone()
        {
            Bolillero Clon = new Bolillero(this);
            return Clon;
        }
    }
}