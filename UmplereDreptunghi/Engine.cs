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

        public static void Draw()
        {
            var mockupData = new { x = 10, y = 10, w = 250, h = 300, ext = Color.Red, interior = Color.Blue };

            Dreptunghi dreptunghi = new Dreptunghi
                (
                new PointF(mockupData.x, mockupData.y),
                mockupData.w,
                mockupData.h,
                mockupData.ext,
                mockupData.interior
                );

            dreptunghi.DesenDreptughi(_graphics);
        }
    }
}
