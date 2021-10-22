using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class EncriptadorBlowFish : Encriptador 
    {
        static BlowFish b = new BlowFish("04B915BA43FEB5B6");
        public EncriptadorBlowFish(): base("BlowFish") 
        {
            
        }

         public override string Encriptar(string pCadena)
        {
           return b.Encrypt_CBC(pCadena);

        }
        public override string Desencriptar(string pCadena)
        {
            return b.Decrypt_CBC(pCadena);
            
        } 
    }
}