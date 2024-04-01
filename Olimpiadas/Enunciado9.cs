using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    internal class Enunciado9 : EnunciadoBase
    {
        private int Respuesta;
        public Enunciado9()
        {
            GenerarEnunciado();
        }
        public override string GenerarEnunciado()
        {
            Random randy = new Random();
            int numero1 = randy.Next(2, 11); // Número 1 entre 1 y 10
            int numero2 = randy.Next(2, 11); // Número 2 entre 1 y 10
            int respuesta = numero1 * numero2;

            Enunciado = $"¿Cuánto es {numero1} * {numero2}?";
            Respuesta = respuesta;
            return Enunciado;
        }

        public override int EntregarRespuesta()
        {
            return Respuesta;
        }
    }
}
