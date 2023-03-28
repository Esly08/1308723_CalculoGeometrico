using System.Runtime.CompilerServices;

namespace Lab10_EslyA._1308723
{
    public class Circulo
    {         
        private double _radio;
        
        public Circulo(double _radio)
        {
            this._radio = _radio;
        }

        private double _Perimetro()
        {
            return 2 * Math.PI * _radio;
        }
        
        private double _Area()
        {
            return Math.PI * (Math.Pow(_radio, 2));
        }

        private double _volumen()
        {
            return 4 * Math.PI * (Math.Pow(_radio, 3)) % 3;
        }

        public void _CalcularGeometria(ref double unPerimetro, ref double unArea, ref double unVolumen)
        {
            unPerimetro = _Perimetro();
            unArea = _Area();
            unVolumen = _volumen();
        }
    }
}