using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Componente
{
    public partial class Visor : UserControl
    {

        int velocidadFondo = 5;

        public Visor()
        {
            InitializeComponent();

            configurarVisorPrincipal(); // visor del fondo
        }

        public void cambiarFondo(Image img)
        {
            Image fondo = reescalado(img, img.Width, this.Height);

            visorPrincipal.Width = fondo.Size.Width;
            visorPrincipal.Height = this.Height;

            visorPrincipal.Location = new Point(0, 0);
            visorPrincipal.BackgroundImage = fondo;


            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);

            visorPrincipal.Refresh();
        }

        private void configurarVisorPrincipal()
        {
            Image img = Properties.Resources.imagenFondo;
            cambiarFondo(img);

        }

        public void mover(int delta)
        {
            if (delta > 0)
            {
                if (((visorPrincipal.Location.X * -1) + this.Width) <= visorPrincipal.Width - velocidadFondo)
                {
                    visorPrincipal.Location = new Point(visorPrincipal.Location.X - 5, visorPrincipal.Location.Y);
                }
            } else
            {
                if (visorPrincipal.Location.X <= -velocidadFondo)
                {
                    visorPrincipal.Location = new Point(visorPrincipal.Location.X + 5, visorPrincipal.Location.Y);
                }
            }
            
        }

        public void mover(Keys key)
        {
            if (key == Keys.A)
            {
                if (visorPrincipal.Location.X <= -velocidadFondo)
                {
                    visorPrincipal.Location = new Point(visorPrincipal.Location.X + 5, visorPrincipal.Location.Y);
                }

            }
            else if (key == Keys.D)
            {
                if (((visorPrincipal.Location.X * -1) + this.Width) <= visorPrincipal.Width - velocidadFondo)
                {
                    visorPrincipal.Location = new Point(visorPrincipal.Location.X - 5, visorPrincipal.Location.Y);
                }
            }
        }

        private Image reescalado(Image imagen, int widht, int height)
        {
            Bitmap fondo = new Bitmap(imagen.Width, height);

            Graphics g = Graphics.FromImage(fondo);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imagen, 0, 0, widht, height);
            g.Dispose();

            return fondo;
        }
    }
}
