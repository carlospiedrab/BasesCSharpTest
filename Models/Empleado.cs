using System;
using System.Collections.Generic;
using System.Linq;
using Models.Extensions;



namespace Models
{
    public class Empleado : Persona
    {
        public Guid NumeroEmpleado { get; set; }
        public double Salario { get; set; }
        public DateOnly FechaIngreso { get; set; }

        public int Antiguedad
        {
            get
            {
                return FechaIngreso.CalcularAntiguedad();
            }
        }

    }
}