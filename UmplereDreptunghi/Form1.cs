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


        /// <summary>
        /// Aceeasta metoda se apeleaza cand Form1 s-a terminat de incarcat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.PopulateWithColors(listContour, listFill);
            Engine.InitGraph(canvas);
        }

        /// <summary>
        /// Aceasta metoda este folosita cand este nevoie sa transmitem noile date alte dreptunghiului.
        /// </summary>
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

        /// <summary>
        /// Aceasta metoda se apeleaza cand apasam pe butonul de "Umple". Aceasta verifica daca datele <b>Origine, Latime sau Lungime</b> au fost modificate si daca au fost, 
        /// deschide un Alert Box care ne informeaza ca nu putem umple dreptunghiul daca modificam datele.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fill_Click(object sender, EventArgs e)
        {
            string invalidText = "Nu poti umple conturul daca ai schimbat datele!";
            string invalidCaption = "Operatie invalida!";

            RefreshDretpunghi();
            bool sizesAreUnmodified = Engine.FillContour(dreptunghi);

            if (!sizesAreUnmodified)
            {
                MessageBox.Show(invalidText, invalidCaption, MessageBoxButtons.OK);
                RefreshDretpunghi();
                return;
            }
        }

        /// <summary>
        /// Aceasta metoda se apeleaza cand apasam pe butonul de "Contureaza".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_contour_Click(object sender, EventArgs e)
        {
            RefreshDretpunghi();
            Engine.DrawContour(dreptunghi);
        }
    }
}
