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
        static Color _backgroundColor = Color.Beige;
        static int _resX, _resY;
        static Dreptunghi _dreptunghi;

        /// <summary>
        /// Aceasta metoda este apelata la incarcarea Form-ului.
        /// </summary>
        /// <param name="pictureBox"></param>
        public static void InitGraph(PictureBox pictureBox)
        {
            _display = pictureBox;
            _resX = pictureBox.Width;
            _resY = pictureBox.Height;
            _bitmap = new Bitmap(_resX, _resY);
            _graphics = Graphics.FromImage(_bitmap);

            FullCanvasClear();
        }

        /// <summary>
        /// Metoda aceasta reface imaginea la reinitializare si sterge toate desenele facute.
        /// </summary>
        static void FullCanvasClear()
        {
            _graphics.Clear(_backgroundColor);
            _display.Image = _bitmap;
        }

        /// <summary>
        /// Aceasta metoda populeaza lista de elemente din ComboBox-urile <paramref name="contour"/> si <paramref name="fill"/> cu culori.
        /// </summary>
        /// <param name="contour"></param>
        /// <param name="fill"></param>
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

        public static void DrawContour(Dreptunghi dreptunghi)
        {
            _dreptunghi = new Dreptunghi(dreptunghi);
            FullCanvasClear();
            _dreptunghi.DesenContur(_graphics);
        }

        public static bool FillContour(Dreptunghi dreptunghi)
        {
            var drpt = new Dreptunghi(_dreptunghi);
            if (!dreptunghi.Origine.Equals(drpt.Origine) || dreptunghi.Latime != drpt.Latime || dreptunghi.Lungime != drpt.Lungime || dreptunghi.CuloareExterior != drpt.CuloareExterior
                || dreptunghi.CuloareInterior != drpt.CuloareInterior)
            {
                FullCanvasClear();
                return false;
            }

            FullCanvasClear();
            _dreptunghi.UmplereContur(_graphics);

            return true;
        }
    }
}
