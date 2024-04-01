using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    internal class Enunciado8 : EnunciadoBase
    {
        private int Respuesta;
        public Enunciado8()
        {
            GenerarEnunciado();
        }
        public override string GenerarEnunciado()
        {
            Random randy = new Random();
            int numero1 = randy.Next(1, 11); // Número 1 entre 1 y 10
            int numero2 = randy.Next(1, 11); // Número 2 entre 1 y 10
            int respuesta = CalcularMCM(numero1, numero2);

            Enunciado = $"¿Cuál es el Mínimo Común Múltiplo de {numero1} y {numero2}?";
            Respuesta = respuesta;
            return Enunciado;
        }

        private int CalcularMCM(int a, int b)
        {
            int maximo = Math.Max(a, b);
            int minimo = Math.Min(a, b);
            int mcm = maximo;

            while (mcm % minimo != 0)
            {
                mcm += maximo;
            }

            return mcm;
        }

        public override int EntregarRespuesta()
        {
            return Respuesta;
        }
    }
}
