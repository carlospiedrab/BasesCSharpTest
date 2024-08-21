using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IContador<T> where T : class
    {
        T Obtener(int index);

        void Agregar(T modelo);

        int Total();

        IEnumerable<T> ObtenerTodos();
    }
}