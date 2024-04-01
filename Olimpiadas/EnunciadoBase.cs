using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    public abstract class EnunciadoBase
    {
        public string Enunciado { get; protected set; }
        public int Respuesta { get; protected set; }

        public abstract string GenerarEnunciado();
        public abstract int EntregarRespuesta();
    }

}
