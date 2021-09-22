using System;
using System.Collections.Generic;

namespace Ej3
{
    public struct CaracterIndice
    {
        char iCaracter;
        int iIndice;

        public CaracterIndice(char pCaracter, int pIndice)
        {
            this.iCaracter = pCaracter;
            this.iIndice = pIndice;

        }

        public char Caracter
        {
            get { return this.iCaracter; }
        }

        public int Indice
        {
            get { return this.iIndice; }
        }


    }
    class AdministradorPalabras
    {
        int iErrores;
        string iPalabra;
        int iCantidadLetrasAcertadas;
        List<CaracterIndice> iEncontrados;


        public AdministradorPalabras(string pPalabra)
        {
            this.iPalabra = pPalabra;
            this.iErrores = 0;
            this.iCantidadLetrasAcertadas = 0;
            this.iEncontrados = new List<CaracterIndice>();
        }

        public int Errores
        {
            get { return this.iErrores; }
        }

        public string Palabra
        {
            get { return this.iPalabra; }
        }


        /// <summary>
        /// Recorre toda la cadena seleccionada para la partida, si la encuentra aumenta en 1 la cantidad de letras acertadas
        /// y sigue recorriendo hasta el final, si la vuelve a encontrar, vuelve a aumentar.. Si no la encuentra aumenta en 1 }
        /// la cantidad de errores
        /// </summary>
        /// <param name="pLetra"> caracter a buscar </param>
        /// 
        /// <returns>verdadero si encuentra al menos uno y falso si no lo encontró</returns>
        public List<CaracterIndice> VerificarLetra(char pLetra)
        {
            bool encontrado = false;
            for (int i = 0; i < iPalabra.Length; i++)
            {
                if (iPalabra[i] == pLetra)
                {
                    if (!this.YaExisteCaracter(i))
                    {
                        this.iEncontrados.Add(new CaracterIndice(pLetra, i));
                        this.iCantidadLetrasAcertadas++;
                        encontrado = true;
                    }
                }
            }
            if (encontrado == false)
            {
                this.iErrores++;
            }

            return this.iEncontrados;
        }

        public bool VerificarSigano()
        {
            return (this.iCantidadLetrasAcertadas == this.iPalabra.Length);
        }

        public bool YaExisteCaracter(int pPosicion)
        {
            bool Existe = false;
            foreach (var i in this.iEncontrados)
            {
                if (i.Indice == pPosicion)
                {
                    Existe = true;
                    break;
                }

            }
            return Existe;
        }







    }
}