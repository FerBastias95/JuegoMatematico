using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    internal class Enunciado2 : EnunciadoBase
    {
        private int Respuesta;
        public Enunciado2()
        {
            GenerarEnunciado();
        }

        public override string GenerarEnunciado()
        {
            Random randy = new Random();
            int x = randy.Next(2, 10);
            int y = randy.Next(2, 10);

            Enunciado = $"Si x = {x} e y = {y}, ¿cuál es el resultado de x * y?";
            Respuesta = x * y;
            return Enunciado;
        }

        public override int EntregarRespuesta()
        {
            return Respuesta;
        }
    }
}
