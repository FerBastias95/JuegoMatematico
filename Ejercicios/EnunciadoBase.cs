using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EnunciadoBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Categoria { get; set; }
        public int Curso { get; set; }
        public bool Avanzado { get; set; }
        public int Inicio1 { get; set; }
        public int Final1 { get; set; }
        public int Inicio2 { get; set; }
        public int Final2 { get; set; }
        public int Inicio3 { get; set; }
        public int Final3;
        public int Inicio4 { get; set; }
        public int Final4 { get; set; }
        public double Respuesta { get; set; }
        public double Variable1 { get; set; }
        public double Variable2 { get; set; }
        public double Variable3 { get; set; }
        public double Variable4 { get; set; }
        public string Enunciado { get; set; }
        public byte[] Imagen { get; set; }
        public string Formula { get; set; }
    }
}
