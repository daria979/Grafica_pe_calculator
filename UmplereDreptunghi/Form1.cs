using System;
using System.Drawing;
using System.Windows.Forms;

namespace UmplereDreptunghi
{
    public partial class Form1 : Form
    {
        int _x;
        int _y;
        int _lungime;
        int _latime;
        Color _contur;
        Color _umplere;

        public Form1()
        {
            InitializeComponent();
        }

        void Draw()
        {
            _x = (int)inputX.Value;
            _y = (int)inputY.Value;
            _lungime = (int)inputWidth.Value;
            _latime = (int)inputHeight.Value;
            _contur = (Color)listContour.SelectedItem;
            _umplere = (Color)listFill.SelectedItem;
            Engine.Draw(new Dreptunghi(new PointF(_x, _y), _lungime, _latime, _contur, _umplere));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.PopulateWithColors(listContour, listFill);
            Engine.InitGraph(canvas);
            Draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
