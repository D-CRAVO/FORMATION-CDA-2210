using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFFigures
{
    public partial class FormFigures : Form
    {
        public FormFigures()
        {
            InitializeComponent();
        }

        public FormFigures(CLFigure.Rectangle _rectangle)
        {
            InitializeComponent();
            double x = _rectangle.X;
            double y = _rectangle.Y;
            double largeur = _rectangle.Largeur;
            double longueur = _rectangle.Longueur;
            Rectangle rectangle1 = new Rectangle(_rectangle.X, _rectangle.Y, _rectangle.Largeur, _rectangle.Longueur);
        }

        private void panelFigures_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red), rectangle1);
        }
    }
}
