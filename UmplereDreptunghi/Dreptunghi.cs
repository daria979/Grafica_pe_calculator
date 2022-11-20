using System.Drawing;

namespace UmplereDreptunghi
{
    public class Dreptunghi
    {
        public Point Origine { set; get; }
        public float Lungime { set; get; }
        public float Latime { set; get; }
        public Color CuloareExterior { set; get; }
        public Color CuloareInterior { set; get; }

        public Dreptunghi(Point origine, float lungime, float latime, Color culoareExterior, Color culoareInterior)
        {
            Origine = origine;
            Lungime = lungime;
            Latime = latime;
            CuloareExterior = culoareExterior;
            CuloareInterior = culoareInterior;
        }
    }
}
