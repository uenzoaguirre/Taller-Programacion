using System;
namespace Ej2
{
    class Fachada 
    {
        RepositorioBanca repositorioBanca;
        double precioDolar = 100;
        // Contructor
        public Fachada()
        {
            this.repositorioBanca = new RepositorioBanca();
        }

        public void CrearCuentaUnificada (string DNI, string Nombre)
        {
           Banca banca = new Banca (DNI,Nombre);
           repositorioBanca.Agregar (banca);
        }

        public bool DebitarEnCuentaPesos (string DNI, double monto)
        {
            Banca banca = repositorioBanca.Obtener (DNI);
            Cuenta cuentaEnPesos = banca.CuentaEnPesos;
             return cuentaEnPesos.DebitarSaldo(monto);
        }

        public bool DebitarEnCuentaDolares (string DNI, double monto)
        {
            Banca banca = repositorioBanca.Obtener (DNI);
            Cuenta cuentaEnDolares = banca.CuentaEnDolares;
            return cuentaEnDolares.DebitarSaldo(monto);
        }

        public void AcreditarEnCuentaPesos (string DNI, double monto)
        {
            Banca banca = repositorioBanca.Obtener (DNI);
            Cuenta cuentaEnPesos = banca.CuentaEnPesos;
            cuentaEnPesos.AcreditarSaldo(monto);
        }

        public void AcreditarEnCuentaDolares (string DNI, double monto)
        {
            Banca banca = repositorioBanca.Obtener (DNI);
            Cuenta cuentaEnDolares = banca.CuentaEnDolares;
            cuentaEnDolares.AcreditarSaldo(monto);
        }

        public double ConsultarSaldoEnPesos  (string DNI)
        {
            Banca banca = repositorioBanca.Obtener (DNI);
            Cuenta cuentaEnPesos = banca.CuentaEnPesos;
            return cuentaEnPesos.Saldo;
        }
        public double ConsultarSaldoEnDolares  (string DNI)
        {
            Banca banca = repositorioBanca.Obtener (DNI);
            Cuenta cuentaEnDolares = banca.CuentaEnDolares;
            return cuentaEnDolares.Saldo;
        }

        public bool TransferirPesosADolar (string DNI, double monto)
        {
           double dolares = monto / this.precioDolar;
           bool debitoExitoso = this.DebitarEnCuentaPesos(DNI,monto);
            if (debitoExitoso) 
           {
            this.AcreditarEnCuentaDolares(DNI,dolares);
           } return debitoExitoso;
        }

        public bool TransferirDolaresAPesos (string DNI, double monto)
        {
           double pesos = monto * this.precioDolar;
           bool debitoExitoso = this.DebitarEnCuentaDolares(DNI,monto);
           if (debitoExitoso) 
           {
            this.AcreditarEnCuentaPesos(DNI,pesos);
            return true;
           } else {return false;}
        }
    } 
    
}