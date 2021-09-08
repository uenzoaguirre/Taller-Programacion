using System;
namespace Ej2
{
    class Moneda 
    {
        //Dentro de la clase se definen los atributos con tipos indicados en el diagrama
        string iCodigoIso;
        string iNombre;
        string iSimbolo;

        
        //Constructor 
        public Moneda (string pCodigoIso , string pNombre , string pSimbolo)
        {
            this.iCodigoIso = pCodigoIso;
            this.iNombre = pNombre;
            this.iSimbolo = pSimbolo;
        }
        //Propiedades
            public string CodigoIso
            {
            get { return this.iCodigoIso; }
            }

            public string Nombre 
            {
                get { return this.iNombre; }
            }

            public string Simbolo 
            {
                get { return this.iSimbolo; }
            }
        }
    }
