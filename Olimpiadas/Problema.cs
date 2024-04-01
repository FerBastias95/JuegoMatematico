using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    internal class Problema
    {
        private List<EnunciadoBase> todosEnunciados = new List<EnunciadoBase>();
        public List<EnunciadoBase> enunciadosSeleccionados = new List<EnunciadoBase>();
        private Random randy = new Random();

        
        public Problema()
        {
            // Agrega instancias de Enunciado1 a la lista de todos los enunciados

            todosEnunciados.Add(new Enunciado1());
            todosEnunciados.Add(new Enunciado2());
            todosEnunciados.Add(new Enunciado3());
            todosEnunciados.Add(new Enunciado4());
            todosEnunciados.Add(new Enunciado5());
            todosEnunciados.Add(new Enunciado6());
            todosEnunciados.Add(new Enunciado7());
            todosEnunciados.Add(new Enunciado8());
            todosEnunciados.Add(new Enunciado9());
            todosEnunciados.Add(new Enunciado10());

            // Selecciona 5 enunciados al azar
            for (int i = 0; i < 5; i++)
            {
                int indiceAleatorio = randy.Next(todosEnunciados.Count);
                enunciadosSeleccionados.Add(todosEnunciados[indiceAleatorio]);
                todosEnunciados.RemoveAt(indiceAleatorio);
            }
        }
    }
}
