using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    internal class Enunciado3 : EnunciadoBase
    {
        private int Respuesta;
        public Enunciado3()
        {
            GenerarEnunciado();
        }
        public override string GenerarEnunciado()
        {
            Random randy = new Random();
            int a = randy.Next(-10, 11); // Coeficiente a entre -10 y 10
            int b = randy.Next(-10, 11); // Coeficiente b entre -10 y 10
            int x = randy.Next(-10, 11); // Valor de x entre -10 y 10
            int respuesta = a * x + b;

            Enunciado = $"Resolver la ecuación lineal {a}x + {b} = {respuesta}";
            Respuesta = x;
            return Enunciado;
        }

        public override int EntregarRespuesta()
        {
            return Respuesta;
        }
    }
}
