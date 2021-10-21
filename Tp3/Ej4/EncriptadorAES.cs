using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class EncriptadorAES: Encriptador 
    {

        public EncriptadorAES(): base("AES")
        {
            
        }

        public override string Encriptar(string pCadena)
        {
            return pCadena;


        }
        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        } 
    }
}