using System;
namespace Ej2
{
    class Cuenta 
    {
        private double iSaldo;  //Atributos   
        Moneda iMoneda;

        //Constructores (Usando sobrecarga)
        public Cuenta (Moneda pMoneda) 
        {
            iMoneda = pMoneda;
            this.iSaldo = 0;
        }
        public Cuenta (Moneda pMoneda, double pSaldoInicial )
        {
            iMoneda = pMoneda;
            this.iSaldo = pSaldoInicial;
            
        } 

        //Propiedad
        public double Saldo 
        {
           get {return iSaldo; }   
        }

        //Metodos 
        public void AcreditarSaldo (double pSaldo)
        {
            this.iSaldo += pSaldo; 
        }

        public bool DebitarSaldo (double pSaldo)
        {
            if (pSaldo < iSaldo) {
                iSaldo -= pSaldo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}