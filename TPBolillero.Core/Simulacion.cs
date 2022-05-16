using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TPBolillero.Core
{
    public class Simulacion
    {

        public long SimularSinHilos(Bolillero bolillero, List<byte> numeros, long veces)
            => bolillero.JugarN(numeros, veces);

        public long SimularConHilos(Bolillero bolillero, List<byte> numeros, long veces, long hilos)
        {
            Task<long>[] tareas = new Task<long>[hilos];
            for(long i = 0; i < hilos; i++)
            {
                var clon = (Bolillero)bolillero.Clone();
                Task uno = Task.Run( () => clon );

            }
            
            return bolillero.JugarN(numeros, veces);
        }
        
    }
}