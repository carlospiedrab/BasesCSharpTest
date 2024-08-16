using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ConvertidorUnidad
    {
        int radio;

        public ConvertidorUnidad(int radio)  // Constructor
        {
            this.radio = radio;
        }

        public int Convertir(int unidad)  // Metodo
        {
            return unidad * radio;
        }
    }
}