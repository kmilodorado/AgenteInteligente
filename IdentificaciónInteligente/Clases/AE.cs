using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace IdentificaciónInteligente.Clases
{
    class AE
    {
        public List<Individuo> IND = new List<Individuo>();
        private int[,] MatImagen;
        private int INDIVIDUO;
        private double UMBRAL;
        private Random AZAR = new Random();

        public AE(int[,] img, double umbral, int individuo)
        {
            MatImagen = img;
            UMBRAL = umbral;
            INDIVIDUO = individuo;
        }

        //Lanzar los individuos en posiciones aleatorias  en diferentes puntos de la imagen
        public void AzarIndividuo()
        {
            int AzarX = AZAR.Next(0, 9), AzarY = AZAR.Next(0, 9);
            bool Salir;
            for (int i = 0; i < INDIVIDUO; i++)
            {
                if (IND.Count > 0)
                {
                    do
                    {
                        AzarX = AZAR.Next(0, 9);
                        AzarY = AZAR.Next(0, 9);
                        Salir = true;
                        for (int j = 0; j < IND.Count; j++)
                        {
                            if (IND[j].X == AzarX && IND[j].X == AzarY)
                            {
                                Salir = false;
                            }
                        }
                    } while (Salir == false);
                    Salir = false;
                }
                IND.Add(new Individuo(AzarX, AzarY, 0, MatImagen[AzarX, AzarY]));
            }
        }

        //Metodo para buscar la distancia mas corta entre dos puntos
        public void BuscarDistancia()
        {
            for (int i = 0; i < IND.Count; i++)
            {
                IND[i].Distancia = BuscarDistancia(i);
                IND[i].Proceso = false;
            }
        }

        //Metodo para hallar la distancia buscada entre dos puntos.
        public double BuscarDistancia(int individuo)
        {
            double DistanciaCal=0, DistanciaCa_Ant = 100, distancia=0;
                for (int j = 0; j < IND.Count; j++)
                {
                    DistanciaCal = DistanciaCalculada(IND[individuo], IND[j]);
                    if (DistanciaCa_Ant > DistanciaCal && DistanciaCal > 0)
                    {
                        DistanciaCa_Ant = DistanciaCal;
                        distancia = Distancia(IND[individuo], IND[j]);
                    }
                }
            return distancia;
        }

        //Metodo para hallar la distancia buscada entre dos puntos.
        public double BuscarDistancia(int x,int y)
        {
            double DistanciaCal = 0, DistanciaCa_Ant = 100, distancia = 0;
            for (int j = 0; j < IND.Count; j++)
            {
                DistanciaCal = DistanciaCalculada(x,y, IND[j]);
                if (DistanciaCa_Ant > DistanciaCal && DistanciaCal > 0)
                {
                    DistanciaCa_Ant = DistanciaCal;
                    distancia = Distancia(x,y, IND[j]);
                }
            }
            return distancia;
        }

        //Metodo para hallar la distancia calculada 
        public double DistanciaCalculada(Individuo a, Individuo b)
        {
            return (Distancia(a, b) - UMBRAL) * b.Validez;
        }

        //Metodo para hallar la distancia calculada 
        public double DistanciaCalculada(int x, int y, Individuo b)
        {
            return (Distancia(x,y,b)-UMBRAL)*b.Validez;
        }
        //Algoritmo Evolutivo

        //Generar Población inicial
        public void GenerarPoblacion()
        {
            for (int i = 0; i < IND.Count; i++)
            {
                IND[i].GenotipoX = Binarizar(IND[i].X, IND[i].GenotipoX.Length);
                IND[i].GenotipoY = Binarizar(IND[i].Y, IND[i].GenotipoY.Length);
            }
        }


        public void Evolucionar(int FactCruce, int FactMutacion)
        {
            int Epocas = 0;
            double[] PromValidez = new double[2], PromDistancia = new double[2];
            PromValidez[0] = PromedioValidez(IND); PromValidez[1] = 0;
            PromDistancia[0] = PromedioDistancia(IND); PromDistancia[1] = 0;

            while ((Error(PromValidez[1], PromValidez[0]) > 0 && Error(PromDistancia[1], PromDistancia[0]) > 0) || Epocas < 30)
            {
                ResetiarIndividuo();

                //Ciclo del cruce
                for (int i = 0; i < FactCruce / 2; i++)
                {

                }

                //Ciclo de mutuación
                for (int i = 0; i < FactMutacion; i++)
                {
                    Mutacion(7);
                }

                PromValidez[1] = PromValidez[0];
                PromValidez[0] = PromedioValidez(IND);
                PromDistancia[1] = PromDistancia[1];
                PromDistancia[0] = PromedioDistancia(IND);
                Epocas++;
            }

        }

        //Metodo para la mutación genetica
        public void Mutacion(int cromosoma)
        {
            int sel = Ruleta();
            double[] PadreX = new double[cromosoma];
            double[] PadreY = new double[cromosoma];
            for (int i = 0; i < cromosoma; i++)
            {
                PadreX[i] = IND[sel].GenotipoX[i];
                PadreY[i] = IND[sel].GenotipoY[i];
            }
            int NX = ProcesarMutuacion(PadreX);
            int NY = ProcesarMutuacion(PadreY);

            if (MatImagen[NX, NY]==1)
            {
                if (Min_Distancia(IND[sel].Distancia,BuscarDistancia(NX,NY)))
                {
                    IND[sel].Distancia = BuscarDistancia(NX, NY);
                    IND[sel].X = NX;
                    IND[sel].Y = NY;
                    IND[sel].GenotipoX = Binarizar(NX, IND[sel].GenotipoX.Length);
                    IND[sel].GenotipoY = Binarizar(NY, IND[sel].GenotipoY.Length);
                    IND[sel].Validez = 1;
                }
            }
            IND[sel].Proceso = true;
        }

        //Metodo para el proceso de mutuacion
        public int ProcesarMutuacion(double[] padre)
        {
            int col_azar, col_cant = AZAR.Next(1, 4), cant = 0, Bin = 0;
            double[] Hijo;
            do
            {
                Hijo = padre;
                while (cant < col_cant)
                {
                    col_azar = AZAR.Next(0, 7);
                    if (padre[col_azar] == 0) { Hijo[col_azar] = 1; } else { Hijo[col_azar] = 0; }
                    cant++;
                }
                Bin = BinToDec(Hijo[0] + "" + Hijo[1] + "" + Hijo[2] + "" + Hijo[3] + "" + Hijo[4] + "" + Hijo[5] + "" + Hijo[6]);
                cant = 0;
            } while (Bin >= 10);

            return Bin;
        }
        
        public bool Min_Distancia(double i1,double i2)
        {
            if (i1>i2)
            {
                return true;
            }
            return false;
        }

        //Metodo para implementacion de la formula para hallar la distancia
        public double Distancia(Individuo i1, Individuo i2)
        {
            return Math.Round(Math.Pow((Math.Pow((i1.X - i2.X), 2) + Math.Pow((i1.Y - i2.Y), 2)), 0.5), 2);
        }

        //Metodo para implementacion de la formula para hallar la distancia
        public double Distancia(int x, int y, Individuo i2)
        {
            return Math.Round(Math.Pow((Math.Pow((x - i2.X), 2) + Math.Pow((y - i2.Y), 2)), 0.5), 2);
        }

        //Metodo para resetiar los procesos de los individuos
        public void ResetiarIndividuo()
        {
            for (int i = 0; i < IND.Count; i++)
            {
                IND[i].Proceso = false;
            }
        }

        //Metodo para calcular el promedio de la validez
        public double PromedioValidez(List<Individuo> individuo)
        {
            double suma = 0;

            for (int i = 0; i < individuo.Count; i++)
            {
                suma = individuo[i].Validez + suma;
            }
            return (suma / individuo.Count);
        }

        //Metodo para calcular el promedio de distancia
        public double PromedioDistancia(List<Individuo> individuo)
        {
            double suma = 0;

            for (int i = 0; i < individuo.Count; i++)
            {
                suma = individuo[i].Distancia + suma;
            }
            return (suma / individuo.Count);
        }

        //Metodo para binarizar un numero en una matriz
        public int[] Binarizar(int valor, int indice)
        {

            int[] matriz = new int[indice];

            String cadena = System.Convert.ToString(valor, 2);
            if (cadena.Length < 6)
            {
                for (int j = cadena.Length - 1; j < 6; j++)
                {
                    cadena = "0" + cadena;
                }
            }
            var chars = cadena.ToCharArray();
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = int.Parse(chars[i] + "");
            }
            return matriz;
        }

        //Metodo para hallar el error
        public double Error(double anterior, double actual)
        {
            return Math.Abs(actual - anterior);
        }

        //Metodo para pasar de Binario a decimal
        public int BinToDec(string binary)
        {
            int exponente = binary.Length - 1;
            int num_decimal = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (int.Parse(binary.Substring(i, 1)) == 1)
                {
                    num_decimal = num_decimal + int.Parse(System.Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }
            return num_decimal;
        }

        //Metodo para selecionador ruleta
        public int Ruleta()
        {
            bool valor = true;
            int n = 0;
            while (valor)
            {
                n = AZAR.Next(0, IND.Count);
                if (IND[n].Proceso == false)
                {
                    valor = false;
                }
            }
            return n;
        }
    }
}
