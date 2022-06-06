using System;
using System.Collections.Generic;
using TPBolillero.Core;
using System.Diagnostics;
using System.Threading;

namespace TPBolillero.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            IAzar a = new Aleatorio();
            Stopwatch stopWatch = new Stopwatch();
            Simulacion simp = new Simulacion();
            Bolillero bol = new Bolillero(a, 100);
            List<byte> jugada = new List<byte> {1,4,6};
            long veces = 1000000;
            System.Console.WriteLine("Simulacion Sin Hilos");
            stopWatch.Start();
            System.Console.WriteLine(simp.SimularSinHilos(bol, jugada, veces)); 
            stopWatch.Stop();
            var ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}",
            ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine("Tiempo de transcurso " + elapsedTime);
            stopWatch.Reset();

            simp.SimularConHilos(bol, jugada, veces, 6);
            
            
            // Get the elapsed time as a TimeSpan value.

            // Format and display the TimeSpan value.
        }
    }
}
