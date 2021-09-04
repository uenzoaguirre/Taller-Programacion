using System;

namespace Ej1
{
    class Circulo //Clase Circulo
    {
        private double iRadio; 
         Punto iCentro; 
        
        //Definimos a continuación las propiedades:
        public double Radio
        {
            get 
            {
                return iRadio;

            }
        }

        public Punto Centro
        {
            get
            {
                return this.iCentro;
            }
        }
        public double Area
        {
            get
            {
                return Math.PI*Math.Pow(Radio,2);
            }
        }
        public double Perimetro
        {
            get
            {
                return 2*Math.PI*Radio;
            }
        }
        
        //Definimos los constructores
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        public Circulo(double pX, double pY, double pRadio) 
        {
            this.iRadio = pRadio;
            this.iCentro = new Punto(pX , pY);
        }
    }
}