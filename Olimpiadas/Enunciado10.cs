using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    internal class Enunciado10 : EnunciadoBase
    {
        private int Respuesta;
        public Enunciado10()
        {
            GenerarEnunciado();
        }
        public override string GenerarEnunciado()
        {
            Random randy = new Random();
            int basePotencia = randy.Next(2, 6); // Números entre 2 y 5 para evitar resultados muy grandes
            int exponente = randy.Next(2, 3); // Exponentes entre 2 y 4 para evitar resultados muy grandes
            int respuesta = (int)Math.Pow(basePotencia, exponente);

            Enunciado = $"¿Cuánto es {basePotencia} elevado a la {exponente}?";
            Respuesta = respuesta;
            return Enunciado;
        }

        public override int EntregarRespuesta()
        {
            return Respuesta;
        }
    }
}
