using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public delegate int Calcular(int p, int q);
namespace Models
{
    public class TestDelegate
    {
        public int num { get; set; }
        public int Sumar(int p, int q)
        {
            num = p + q;
            return num;
        }
        public int Multiplicar(int p, int q)
        {
            num = p * q;
            return num;
        }

        public int Restar(int p, int q)
        {
            num = p * q;
            return num;
        }
    }
}