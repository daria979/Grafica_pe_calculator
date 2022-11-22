using System.Drawing;

namespace UmplereDreptunghi
{
    /// <summary>
    /// Clasa ce va contine datele unui dreptunghi si functiile de desenare.
    /// </summary>
    public class Dreptunghi
    {
        public PointF Origine { set; get; }
        public int Lungime { set; get; }
        public int Latime { set; get; }
        public Color CuloareExterior { set; get; }
        public Color CuloareInterior { set; get; }

        public Dreptunghi(PointF origine, int lungime, int latime, Color culoareExterior, Color culoareInterior)
        {
            Origine = origine;
            Lungime = lungime;
            Latime = latime;
            CuloareExterior = culoareExterior;
            CuloareInterior = culoareInterior;
        }

        public Dreptunghi(Dreptunghi dreptunghi)
        {
            Origine = dreptunghi.Origine;
            Lungime = dreptunghi.Lungime;
            Latime = dreptunghi.Latime;
            CuloareExterior = dreptunghi.CuloareExterior;
            CuloareInterior = dreptunghi.CuloareInterior;
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

        /// <summary>
        /// Aceasta metoda genereaza conturul dreptunghiului.
        /// </summary>
        /// <param name="graphics"></param>
        public void DesenContur(Graphics graphics)
        {
            Rectangle dreptunghi = new Rectangle((int)Origine.X, (int)Origine.Y, Lungime, Latime);

            graphics.DrawRectangle(new Pen(CuloareExterior, 3), dreptunghi);
        }

        /// <summary>
        /// Aceasta metoda umple conturul dreptunghiului.
        /// </summary>
        /// <param name="graphics"></param>
        public void UmplereContur(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle((int)Origine.X, (int)Origine.Y, Lungime, Latime);

            graphics.FillRectangle(new SolidBrush(CuloareInterior),
                                   new Rectangle
                                   {
                                       X = rectangle.X + 1,
                                       Y = rectangle.Y + 1,
                                       Height = rectangle.Height - 1,
                                       Width = rectangle.Width - 1
                                   });
        }

        /// <summary>
        /// Aceasta metoda verifica egalitate intre doua Dreptunghiuri bazandu-se pe Origine, Lungime si Latime.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var a = (obj is Dreptunghi dreptunghi) &&
                (dreptunghi.Origine == Origine &&
                dreptunghi.Lungime == Lungime &&
                dreptunghi.Latime == Latime
                );

            return a;
        }
    }
}
