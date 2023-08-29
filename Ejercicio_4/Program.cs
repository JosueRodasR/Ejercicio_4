    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alumnosPorSalon = 40; 
            int tiempoSalonA = 5;
            int tiempoSalonB = 8;
            int tiempoSalonC = 6;

            int totalAlumnos = 3 * alumnosPorSalon;

            int tiempoTotalMinutos = (alumnosPorSalon *tiempoSalonA) + (alumnosPorSalon* tiempoSalonB) + (alumnosPorSalon * tiempoSalonC);
            
            int horas = tiempoTotalMinutos / 60;
            int minutos = tiempoTotalMinutos % 60;

            Console.WriteLine($"El instructor se tardara en revisar {horas} horas y {minutos} minutos en revisar todos los examenes.");
            Console.ReadKey();
        }
    }
}
