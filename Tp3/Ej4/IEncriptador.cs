using System;

namespace Ej4
{
    public interface IEncriptador
    {
        string Encriptar(string pCadena);

        string Desencriptar(string pCadena);
    }

}