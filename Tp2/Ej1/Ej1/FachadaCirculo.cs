using System;

namespace Ej1
{
    class FachadaCirculo
    {
        public double CalcularArea(double x, double y, double Radio)
        {
            Circulo Circ = new Circulo(x, y, Radio);
            return Circ.Area;
        }

        public double CalcularPerimetro(double x, double y, double Radio)
        {
            Circulo Circ = new Circulo(x, y, Radio);
            return Circ.Perimetro;
        }
    }
}

