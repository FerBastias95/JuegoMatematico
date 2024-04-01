using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    internal class Enunciado4 : EnunciadoBase
    {
        private int Respuesta;
        public Enunciado4()
        {
            GenerarEnunciado();
        }
        public override string GenerarEnunciado()
        {
            Random randy = new Random();
            int num1 = randy.Next(1, 11); // Número 1 entre 1 y 10
            int num2 = randy.Next(1, 11); // Número 2 entre 1 y 10
            int respuesta = num1 * num2;

            Enunciado = $"¿Cuánto es {num1} * {num2}?";
            Respuesta = respuesta;
            return Enunciado;
        }

        public override int EntregarRespuesta()
        {
            return Respuesta;
        }
    }
}
