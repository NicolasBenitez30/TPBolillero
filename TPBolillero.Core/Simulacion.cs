using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TPBolillero.Core
{
    public class Simulacion
    {

        public long SimularSinHilos(Bolillero bolillero, List<byte> numeros, long veces)
            => bolillero.JugarN(numeros, veces);

        public long SimularConHilos(Bolillero bolillero, List<byte> numeros, long veces, int hilos)
        {
            Task<long>[] tareas = new Task<long>[hilos];
            for(int i = 0; i < hilos; i++)
            {
                var clon = (Bolillero)bolillero.Clone();
                Task tareas[i] = Task.Run( () => SimularSinHilos(clon, numeros, veces/hilos));
                

            }
            
            return bolillero.JugarN(numeros, veces);
        }
        
    }
}