using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7
{
    internal class Datos
    {
        string nombre;
        string apellido;
        int noCasa;
        int cuota;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NoCasa { get => noCasa; set => noCasa = value; }
        public int Cuota { get => cuota; set => cuota = value; }
    }
}
