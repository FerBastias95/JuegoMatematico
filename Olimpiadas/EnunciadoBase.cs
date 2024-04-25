using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas
{
    public class EnunciadoBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Categoria { get; set; }
        public int Curso { get; set; }
        public bool Avanzado { get; set; }
        public bool Decimal1 { get; set; }
        public bool Decimal2 { get; set; }
        public bool Decimal3 { get; set; }
        public bool Decimal4 { get; set; }
        public double Inicio1 { get; set; }
        public double Final1 { get; set; }
        public double Inicio2 { get; set; }
        public double Final2 { get; set; }
        public double Inicio3 { get; set; }
        public double Final3;
        public double Inicio4 { get; set; }
        public double Final4 { get; set; }
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
