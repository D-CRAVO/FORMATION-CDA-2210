using CLFigure;
using CLGraphics;
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
        GraphicRectangle tempRect;
        System.Drawing.Rectangle rectangle;
        GraphicCercle tempCerc;
        System.Drawing.Rectangle cercle;
        public FormFigures()
        {
            InitializeComponent();
        }

        public FormFigures(CLFigure.Rectangle _rectangle)
        {
            InitializeComponent();
            tempRect = new GraphicRectangle(_rectangle);
            rectangle = new System.Drawing.Rectangle(tempRect.X, tempRect.Y, tempRect.Longueur, tempRect.Largeur);
        }

        public FormFigures(CLFigure.Cercle _cercle)
        {
            InitializeComponent();
            tempCerc = new GraphicCercle(_cercle);
            cercle = new System.Drawing.Rectangle(tempCerc.X, tempCerc.Y, tempCerc.Longueur, tempCerc.Largeur);
        }

        private void panelFigures_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red), rectangle);
            e.Graphics.DrawEllipse(new Pen(Color.Blue), cercle);
        }
    }
}
