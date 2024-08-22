using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalcularAntiguedad(this DateOnly fecha)  // no queremos pasar como parametro, usamos el this si se detecta el tipo de dato
        {
            DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);
            int antiguedad = hoy.Year - fecha.Year;
            if (fecha > hoy.AddYears(-antiguedad)) antiguedad--;

            return antiguedad;
        }
    }
}