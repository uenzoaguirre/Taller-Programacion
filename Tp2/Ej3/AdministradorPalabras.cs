using System;
using System.Collections.Generic;

namespace Ej3
{
    class AdministradorPalabras
    {
        int iErrores;
        string iPalabra;
        int iCantidadLetrasAcertadas;

        public AdministradorPalabras(string pPalabra) 
        {
            this.iPalabra = pPalabra;
            this.iErrores = 0;
            this.iCantidadLetrasAcertadas = 0;
        }

         public int Errores
         {
            get {return  this.iErrores; }
        }

    /// <summary>
    /// Recorre toda la cadena seleccionada para la partida, si la encuentra aumenta en 1 la cantidad de letras acertadas
    /// y sigue recorriendo hasta el final, si la vuelve a encontrar, vuelve a aumentar.. Si no la encuentra aumenta en 1 }
    /// la cantidad de errores
    /// </summary>
    /// <param name="pLetra"> caracter a buscar </param>
    /// 
    /// <returns>verdadero si encuentra al menos uno y falso si no lo encontró</returns>
        public bool VerificarLetra(char pLetra)
        {
            bool encontrado = false;
            foreach (var caracter in this.iPalabra)
           {
               if (caracter == pLetra) 
               {
                    this.iCantidadLetrasAcertadas++;
                    encontrado = true;
                }
           }
            if (encontrado == false)
            {
                this.iErrores++;
            }
            
            return encontrado;
        }

        public bool VerificarSigano()
        {
            return (this.iCantidadLetrasAcertadas == this.iPalabra.Length);
        } 
       
    }
}