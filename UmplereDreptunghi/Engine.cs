using System.Drawing;
using System.Windows.Forms;

namespace UmplereDreptunghi
{
    public static class Engine
    {
        static PictureBox display { get; set; }
        static Graphics grp { get; set; }
        static Bitmap bmp { get; set; }
        static PointF center { get; set; }
        static int ResX, ResY;

        public static void InitGraph(PictureBox pictureBox)
        {
            display = pictureBox;
            ResX = pictureBox.Width;
            ResY = pictureBox.Height;
            bmp = new Bitmap(ResX, ResY);
            grp = Graphics.FromImage(bmp);
            center = new PointF(ResX / 2, ResY / 2);
        }
    }
}
