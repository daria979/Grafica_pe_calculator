using System;
using System.Drawing;
using System.Windows.Forms;

namespace UmplereDreptunghi
{
    public partial class Form1 : Form
    {
        Dreptunghi dreptunghi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.PopulateWithColors(listContour, listFill);
            Engine.InitGraph(canvas);
        }

        void RefreshDretpunghi()
        {
            int x = (int)inputX.Value;
            int y = (int)inputY.Value;
            int lungime = (int)inputWidth.Value;
            int latime = (int)inputHeight.Value;
            Color contur = (Color)listContour.SelectedItem;
            Color umplere = (Color)listFill.SelectedItem;

            dreptunghi = new Dreptunghi(new PointF(x, y), lungime, latime, contur, umplere);
        }

        private void button_fill_Click(object sender, EventArgs e)
        {
            RefreshDretpunghi();
            bool sizesAreUnmodified = Engine.FillContour(dreptunghi);

            if (!sizesAreUnmodified)
            {
                MessageBox.Show("Nu poti umple conturul daca ai schimbat datele!", "Operatie invalida!", MessageBoxButtons.OK);
                RefreshDretpunghi();
                return;
            }
        }

        private void button_contour_Click(object sender, EventArgs e)
        {
            RefreshDretpunghi();
            Engine.DrawContour(dreptunghi);
        }
    }
}
