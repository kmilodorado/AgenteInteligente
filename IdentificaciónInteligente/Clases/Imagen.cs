using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IdentificaciónInteligente.Clases
{
    public class Imagen
    {
        int Width, Height;
        int[,] Matrix;
        Bitmap imag;
        int[,] MatrixV, MatrixH;

        public Imagen()
        {

        }
        public int Width1
        {
            get
            {
                return Width;
            }

            set
            {
                Width = value;
            }
        }

        public int Height1
        {
            get
            {
                return Height;
            }

            set
            {
                Height = value;
            }
        }

        public int[,] Matrix1
        {
            get
            {
                return Matrix;
            }

            set
            {
                Matrix = value;
            }
        }

        public Bitmap Imag
        {
            get
            {
                return imag;
            }

            set
            {
                imag = value;
            }
        }

        public Imagen(int width, int height, Bitmap ima)
        {
            Width = width;
            Height = height;
            imag = ima;
            Matrix= new int[Width,Height];

        }

        public void llenarMatrix(int i, int j, int valor)
        {
            Matrix[i, j] = valor;
            ComparaciónVertical();
        }


        public string Mostrar()
        {
            string mostrar="";
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    mostrar += Matrix[i, j];
                    
                }
                mostrar += "\n";
            }
            return mostrar;
        }


        public void ComparaciónVertical() {

            
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j=j+2)
                {
                    int com = 0;

                    com = Matrix[i, j] + Matrix[i, j+1];
                    Console.Write(com);
                }
            }

            
            
                }
        
    }
}
