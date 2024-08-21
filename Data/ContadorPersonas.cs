using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Interfaces;
using Models;

namespace Data
{
    public class ContadorPersonas : IContador<Persona>
    {
        public int Index { get; set; } = 0;
        public List<Persona> personas = new List<Persona>();

        public void Agregar(Persona modelo)
        {
            personas.Add(modelo);
            Index++;
        }

        public Persona Obtener(int index)
        {
            return personas.Find(x => x.Id == index);
        }

        public int Total()
        {
            return personas.Count;
        }

        public IEnumerable<Persona> ObtenerTodos()
        {
            return personas.ToList();
        }
    }
}