using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7
{
    internal class Propiedad
    {
        int numCasa;
        string dpi;
        int cuota;

        public int NumCasa { get => numCasa; set => numCasa = value; }
        public string Dpi { get => dpi; set => dpi = value; }
        public int Cuota { get => cuota; set => cuota = value; }
    }
}
