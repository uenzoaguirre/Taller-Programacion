using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class FabricaEncriptadores
    {
        

        private Dictionary<string, Encriptador> iEncriptadores;
        private FabricaEncriptadores()
        {
            iEncriptadores = new Dictionary<string, Encriptador>();
            iEncriptadores.Add("Cesar", new EncriptadorCesar(4));
            iEncriptadores.Add("AES", new EncriptadorAES());
            iEncriptadores.Add("Null", new EncriptadorNulo());
            iEncriptadores.Add("BlowFish", new EncriptadorBlowFish());
            iEncriptadores.Add("DES", new EncriptadorDES());
        }

        private static FabricaEncriptadores cInstancia;

        public static FabricaEncriptadores Instance
        {
            get
            {
                if (cInstancia == null)
                {
                    cInstancia = new FabricaEncriptadores();
                }
                return cInstancia;
            }

        }

        public Encriptador GetEncriptador(string Nombre)
        {
            return iEncriptadores[Nombre];
        }

    }

}