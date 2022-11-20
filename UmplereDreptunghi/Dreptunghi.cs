using System.Drawing;

namespace UmplereDreptunghi
{
    /// <summary>
    /// Clasa ce va contine datele unui dreptunghi.
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
    }
}
