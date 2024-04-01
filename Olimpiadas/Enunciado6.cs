using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    internal class Enunciado6 : EnunciadoBase
    {
        private int Respuesta;

        public Enunciado6() {
            GenerarEnunciado();
        }
        public override string GenerarEnunciado()
        {
            Random randy = new Random();
            int num1 = randy.Next(1, 101); // Número 1 entre 1 y 100
            int num2 = randy.Next(1, 101); // Número 2 entre 1 y 100
            int respuesta = num1 - num2;

            Enunciado = $"¿Cuánto es {num1} - {num2}?";
            Respuesta = respuesta;
            return Enunciado;
        }

        public override int EntregarRespuesta()
        {
            return Respuesta;
        }
    }
}
