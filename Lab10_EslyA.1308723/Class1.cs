using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_EslyA._1308723
{
    public class Class1
    {
        public static void Main()
        {
            
            Console.WriteLine("Bienvenido a los cálculos geométricos");
            Console.WriteLine("");
            Console.WriteLine("Por favor ingrese el radio del círculo");
            double _Rad1 = double.Parse(Console.ReadLine());
            Circulo objCirculo = new Circulo(_Rad1);

            double _per = 0.0;
            double _ar = 0.0;
            double _vol = 0;

            objCirculo._CalcularGeometria(ref _per, ref _ar, ref _vol);

            Console.WriteLine("El perímetro es: " + _per);
            Console.WriteLine("El área es: " + _ar);
            Console.WriteLine("El volumen es: " + _vol);

        }
    }
}
