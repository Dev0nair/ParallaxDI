using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParaProbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += mover;
            this.MouseWheel += mover2;
        }

        private void mover(object sender, KeyEventArgs e)
        {
            visor1.mover(e.KeyCode);
        }

        private void mover2(object sender, MouseEventArgs e)
        {
            visor1.mover(e.Delta);
        }
        
    }
}
