using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    internal class Enunciado1 : EnunciadoBase
    {
        List<(int, int, int)> triosPitagoricos = new List<(int, int, int)>()
        {
            (3, 4, 5),
            (6, 8, 10),
            (5, 12, 13),
            (9, 12, 15),
            (8, 15, 17),
            (12, 16, 20),
            (15, 20, 25),
        };

        private int Respuesta;

        public Enunciado1()
        {
            GenerarEnunciado();
        }


        public override int EntregarRespuesta()
        {
            return Respuesta;
        }

        public override string GenerarEnunciado()
        {
            Random randy = new Random();
            // Generar un índice aleatorio dentro del rango de la lista
            int indiceAleatorio = randy.Next(triosPitagoricos.Count);

            // Obtener el trío pitagórico correspondiente al índice aleatorio
            (int a, int b, int respuestaTrío) = triosPitagoricos[indiceAleatorio];

            // Asignar el valor de la respuesta a la variable de instancia
            Respuesta = respuestaTrío;

            // Generar el enunciado utilizando las variables a y b del trío pitagórico
            string Enunciado = $"En un triángulo rectángulo, la longitud de los catetos es {a} y {b}. ¿Cuál es la longitud de la hipotenusa?";

            return Enunciado;
        }
    }
}
