using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_course.Advancedshit.Events
{
    public class TemperaturaArgs : EventArgs
{
    public double Temperatura { get; }
    public TemperaturaArgs(double temp) => Temperatura = temp;
}

public class Termometro
{
    public event EventHandler<TemperaturaArgs> AlertaTemperatura;
    
    public void CambiarTemperatura(double nuevaTemp)
    {
        if (nuevaTemp >= 100)
            AlertaTemperatura?.Invoke(this, new TemperaturaArgs(nuevaTemp));
    }
}
/*
// Suscriptor lambda:
    termo.AlarmaTemperatura += (sender, args) => 
    Console.WriteLine($"¡Alerta! Temp: {args.Temperatura}");
*/
}