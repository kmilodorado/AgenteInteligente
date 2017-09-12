using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificaciónInteligente.Clases
{
    class Individuo
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int[] GenotipoX { get; set; }
        public int[] GenotipoY { get; set; }
        public int Fenotipo { get; set; }
        public double Distancia { get; set; }
       public int Validez { get; set; }

        public bool Proceso { get;  set; }

        public Individuo()
        {
            X = 0;
            Y = 0;
            Distancia = 0;
            Validez = 0;
            Proceso = false;
        }

        public Individuo(int x, int y, double distincia, int validez)
        {
            X = x;
            Y = y;
            GenotipoX = new int[7];
            GenotipoY = new int[7];
            Distancia = distincia;
            Validez = validez;
            Proceso = false;
        }
    }
}
