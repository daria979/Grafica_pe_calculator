using System.Drawing;

namespace UmplereDreptunghi
{
    /// <summary>
    /// Clasa ce va contine datele unui dreptunghi si functiile de desenare.
    /// </summary>
    public class Dreptunghi
    {
        static PointF Origine { set; get; }
        static int Lungime { set; get; }
        static int Latime { set; get; }
        static Color CuloareExterior { set; get; }
        static Color CuloareInterior { set; get; }

        public Dreptunghi(PointF origine, int lungime, int latime, Color culoareExterior, Color culoareInterior)
        {
            Origine = origine;
            Lungime = lungime;
            Latime = latime;
            CuloareExterior = culoareExterior;
            CuloareInterior = culoareInterior;
        }

        /// <summary>
        /// Functia ce deseneaza dreptunghiul propriu zis.
        /// </summary>
        /// <param name="graphics"></param>
        public void DesenDreptughi(Graphics graphics)
        {
            Rectangle dreptunghi = new Rectangle((int)Origine.X, (int)Origine.Y, Lungime, Latime);

            DesenContur(graphics, dreptunghi);
            UmplereContur(graphics, dreptunghi);
        }

        void DesenContur(Graphics graphics, Rectangle rectangle) =>
            graphics.DrawRectangle(new Pen(CuloareExterior, 3), rectangle);

        void UmplereContur(Graphics graphics, Rectangle rectangle) =>
            graphics.FillRectangle(new SolidBrush(CuloareInterior),
                                   new Rectangle
                                   {
                                       X = rectangle.X + 1,
                                       Y = rectangle.Y + 1,
                                       Height = rectangle.Height - 1,
                                       Width = rectangle.Width - 1
                                   });

    }
}
