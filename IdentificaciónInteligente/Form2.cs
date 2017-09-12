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
    public partial class Form2 : Form
    {
        public Form2( string a)
        {
            InitializeComponent();
            label1.Text =a;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
