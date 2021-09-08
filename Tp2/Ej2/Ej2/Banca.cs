using System;
namespace Ej2
{
    class Banca //Representamos cuenta unificada del cliente
    {
        Cuenta iCuentaEnPesos;
        Cuenta iCuentaEnDolares;
        string iNumero;
        string iNombre;
        //Constructor
        public Banca (string pNumero , string pTitular)
        {
            this.iNumero = pNumero;
            this.iNombre = pTitular;

            this.iCuentaEnPesos = new Cuenta (new Moneda ("ARS" ,"Peso argentino" , "$"));
            this.iCuentaEnDolares = new Cuenta (new Moneda("USD" , "dólar estadounidense", "$"));
        }

        //Propiedades
        public Cuenta CuentaEnPesos
        {
            get {return this.iCuentaEnPesos;}
        }

        public Cuenta CuentaEnDolares
        {
            get {return this.iCuentaEnDolares;}
        }

        public string Numero
        {
            get {return this.iNumero;}
        }

         public string Titular
        {
            get {return this.iNombre;}
        }
    }
}
