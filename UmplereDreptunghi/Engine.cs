using System;
using System.Drawing;
using System.Windows.Forms;

namespace UmplereDreptunghi
{
    public static class Engine
    {
        static PictureBox _display;
        static Graphics _graphics;
        static Bitmap _bitmap;
        static PointF _center;
        static Color _backgroundColor = Color.Beige;
        static int _resX, _resY;
        static Dreptunghi _dreptunghi;

        /// <summary>
        /// Aceasta metoda este reapelata de fiecare data cand 
        /// </summary>
        /// <param name="pictureBox"></param>
        public static void InitGraph(PictureBox pictureBox)
        {
            _display = pictureBox;
            _resX = pictureBox.Width;
            _resY = pictureBox.Height;
            _bitmap = new Bitmap(_resX, _resY);
            _graphics = Graphics.FromImage(_bitmap);
            _center = new PointF(_resX / 2, _resY / 2);
            ClearGraph();
            RefreshGraph();
        }

        static void ClearGraph()
        {
            _graphics.Clear(_backgroundColor);
        }

        /// <summary>
        /// Metoda aceasta reface imaginea la reinitializare.
        /// </summary>
        static void RefreshGraph()
        {
            _display.Image = _bitmap;
        }

        public static void Draw(Dreptunghi dreptunghi)
        {
            ClearGraph();
            RefreshGraph();
            _dreptunghi= dreptunghi;
            dreptunghi.DesenDreptughi(_graphics);
        }

        public static void Draw()
        {
            ClearGraph();
            RefreshGraph();
            _dreptunghi.DesenDreptughi(_graphics);
        }

        public static void PopulateWithColors(ComboBox contour, ComboBox fill)
        {
            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));

            foreach (var color in colors)
            {
                contour.Items.Add(Color.FromKnownColor(color));
                fill.Items.Add(Color.FromKnownColor(color));
            }

            fill.SelectedItem = Color.Black;
            contour.SelectedItem = Color.Black;
        }
    }
}
