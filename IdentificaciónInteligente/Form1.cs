using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdentificaciónInteligente.Clases;

namespace IdentificaciónInteligente
{
    public partial class Form1 : Form 
    {
        
        OpenFileDialog op = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_tratamiento_Click(object sender, EventArgs e)
        {
             Algoritmo alg = new Algoritmo();
            Bitmap bit = new Bitmap(pictureBox1.Image);
          
            pictureBox1.Image =  alg.EscalaDeGrises(bit, 100);
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = "binarización de la imagen cargada";

          
            
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_examinar_Click(object sender, EventArgs e)
        {
           
          //  op.Filter = "Archivo BMP|*.bmp ";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
                textBox1.Text = "Carga de imagen";
            }
           

           
        }
    }
}
