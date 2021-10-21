using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class EncriptadorCesar : Encriptador
    {

        int iDesplazamiento;
        static string abc = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|.;:{}[]*";

        public EncriptadorCesar(int pDesplazamiento) : base("Cesar")
        {
            this.iDesplazamiento = pDesplazamiento;
        }

        public override string Encriptar(string pCadena)
        {
            string cifrado = "";
            //recorre caracter a caracter el mensaje a cifrar
            for (int i = 0; i < pCadena.Length; i++)
            {
                int posCaracter = getPosABC(pCadena[i]);
                if (posCaracter != -1) //el caracter existe en la variable abc
                {
                    int pos = posCaracter + this.iDesplazamiento;
                    while (pos >= abc.Length)
                    {
                        pos = pos - abc.Length;
                    }
                    //concatena al mensaje cifrado
                    cifrado += abc[pos];
                }
                else//si no existe el caracter no se cifra
                {
                    cifrado += pCadena[i];
                }
            }
            return cifrado;

        }
        private static int getPosABC(char caracter)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                if (caracter == abc[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public override string Desencriptar(string pCadena)
        {
            string cifrado = "";
            for (int i = 0; i < pCadena.Length; i++)
            {
                int posCaracter = getPosABC(pCadena[i]);
                if (posCaracter != -1) //el caracter existe en la variable abc
                {
                    int pos = posCaracter - iDesplazamiento;
                    while (pos < 0)
                    {
                        pos = pos + abc.Length;
                    }
                    cifrado += abc[pos];
                }
                else
                {
                    cifrado += pCadena[i];
                }
                
            }
            return cifrado;
        }
    }
}




