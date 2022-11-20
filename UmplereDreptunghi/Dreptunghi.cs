using System.Drawing;

namespace UmplereDreptunghi
{
    /// <summary>
    /// Clasa ce va contine datele unui dreptunghi si functiile de desenare.
    /// </summary>
    public class Dreptunghi
    {
        PointF Origine { set; get; }
        int Lungime { set; get; }
        int Latime { set; get; }
        Color CuloareExterior { set; get; }
        Color CuloareInterior { set; get; }

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
            graphics.DrawRectangle(new Pen(CuloareExterior), rectangle);

        void UmplereContur(Graphics graphics, Rectangle rectangle) =>
            graphics.FillRectangle(new SolidBrush(CuloareInterior), rectangle);

    }
}
