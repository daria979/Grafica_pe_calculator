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

        public static void ClearGraph()
        {
            _graphics.Clear(_backgroundColor);
        }

        public static void RefreshGraph()
        {
            _display.Image = _bitmap;
        }
    }
}
