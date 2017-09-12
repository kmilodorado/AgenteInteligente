using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentificaciónInteligente.Clases;
using System.Windows.Forms;

namespace IdentificaciónInteligente.Clases
{
    class Algoritmo
    {
        Form2 fom;
        // METODO DE ESCALA DE GRISES
        public Bitmap EscalaDeGrises(Bitmap source, int Umbral)
        {
            // Bitmap con la imagen binaria
            Bitmap imagen = new Bitmap(source.Width, source.Height, source.PixelFormat);
            Imagen img = new Imagen(source.Width, source.Height, imagen);
            // Recorrer pixel de la imagen
            for (int i = 0; i < source.Width; i++)
            {
                for (int e = 0; e < source.Height; e++)
                {
                    // Color del pixel
                    Color coloor = source.GetPixel(i, e);
                    // Escala de grises
                    byte gray = (byte)(coloor.R * 0.3f + coloor.G * 0.59f + coloor.B * 0.11f);
                    // Blanco o negro
                    byte value = 255;
                    img.llenarMatrix(i, e, 0);
                    if (gray > Umbral)
                    {
                        value = 0;
                        img.llenarMatrix(i, e, 1);
                    }
                                                           
                    // Asginar nuevo color
                    Color NuevoColor = System.Drawing.Color.FromArgb(value, value, value);
                    imagen.SetPixel(i, e, NuevoColor);

                }
            }

            fom = new Form2(img.Mostrar());
            fom.Show();

            return img.Imag ;
        }       

      

    }
}
