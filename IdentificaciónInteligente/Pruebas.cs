using IdentificaciónInteligente.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentificaciónInteligente
{
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] img = new int[10,10];
            img[0, 0] = 0; img[1, 0] = 0; img[2, 0] = 0; img[3, 0] = 0; img[4, 0] = 0; img[5, 0] = 0; img[6, 0] = 0; img[7, 0] = 0; img[8, 0] = 0; img[9, 0] = 0;
            img[0, 1] = 0; img[1, 1] = 0; img[2, 1] = 0; img[3, 1] = 0; img[4, 1] = 0; img[5, 1] = 0; img[6, 1] = 0; img[7, 1] = 0; img[8, 1] = 0; img[9, 1] = 0;
            img[0, 2] = 0; img[1, 2] = 0; img[2, 2] = 1; img[3, 2] = 1; img[4, 2] = 1; img[5, 2] = 1; img[6, 2] = 1; img[7, 2] = 1; img[8, 2] = 0; img[9, 2] = 0;
            img[0, 3] = 0; img[1, 3] = 0; img[2, 3] = 1; img[3, 3] = 0; img[4, 3] = 0; img[5, 3] = 0; img[6, 3] = 0; img[7, 3] = 1; img[8, 3] = 0; img[9, 3] = 0;
            img[0, 4] = 0; img[1, 4] = 0; img[2, 4] = 1; img[3, 4] = 0; img[4, 4] = 0; img[5, 4] = 0; img[6, 4] = 0; img[7, 4] = 1; img[8, 4] = 0; img[9, 4] = 0;
            img[0, 5] = 0; img[1, 5] = 0; img[2, 5] = 1; img[3, 5] = 0; img[4, 5] = 0; img[5, 5] = 0; img[6, 5] = 0; img[7, 5] = 1; img[8, 5] = 0; img[9, 5] = 0;
            img[0, 6] = 0; img[1, 6] = 0; img[2, 6] = 1; img[3, 6] = 0; img[4, 6] = 0; img[5, 6] = 0; img[6, 6] = 0; img[7, 6] = 1; img[8, 6] = 0; img[9, 6] = 0;
            img[0, 7] = 0; img[1, 7] = 0; img[2, 7] = 1; img[3, 7] = 1; img[4, 7] = 1; img[5, 7] = 1; img[6, 7] = 1; img[7, 7] = 1; img[8, 7] = 0; img[9, 7] = 0;
            img[0, 8] = 0; img[1, 8] = 0; img[2, 8] = 0; img[3, 8] = 0; img[4, 8] = 0; img[5, 8] = 0; img[6, 8] = 0; img[7, 8] = 0; img[8, 8] = 0; img[9, 8] = 0;
            img[0, 9] = 0; img[1, 9] = 0; img[2, 9] = 0; img[3, 9] = 0; img[4, 9] = 0; img[5, 9] = 0; img[6, 9] = 0; img[7, 9] = 0; img[8, 9] = 0; img[9, 9] = 0;

            AE ae = new AE(img,2,5);
            do
            {
                ae.AzarIndividuo();
            } while (ObtenerValidez(ae.IND));
           
            ae.BuscarDistancia();
            ae.GenerarPoblacion();
        }

        private bool ObtenerValidez(List<Individuo> individuo) {
            for (int i = 0; i < individuo.Count; i++)
            {
                if (individuo[i].Validez==1)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
