using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class Fachada
    {
        FabricaEncriptadores Encriptadores=FabricaEncriptadores.Instance;

        public string EncriptarCesar(string pCadena)
        {
            return Encriptadores.GetEncriptador("Cesar").Encriptar(pCadena);
        }
        public string DesencriptarCesar(string pCadena)
        {
            return Encriptadores.GetEncriptador("Cesar").Desencriptar(pCadena);
        }
        public string EncriptarAES(string pCadena)
        {
            return Encriptadores.GetEncriptador("AES").Encriptar(pCadena);
        }
         public string DesencriptarAES(string pCadena)
        {
            return Encriptadores.GetEncriptador("AES").Desencriptar(pCadena);
        }
         public string EncriptarBlowFish(string pCadena)
        {
            return Encriptadores.GetEncriptador("BlowFish").Encriptar(pCadena);
        }
         public string DesencriptarBlowFish(string pCadena)
        {
            return Encriptadores.GetEncriptador("BlowFish").Desencriptar(pCadena);
        }
         public string EncriptarDES(string pCadena)
        {
            return Encriptadores.GetEncriptador("DES").Encriptar(pCadena);
        }
         public string DesencriptarDES(string pCadena)
        {
            return Encriptadores.GetEncriptador("DES").Desencriptar(pCadena);
        }
         

    }
}