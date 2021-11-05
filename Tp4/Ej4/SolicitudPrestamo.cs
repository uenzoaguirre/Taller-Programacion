using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class SolicitudPrestamo
    {
        double iMonto;
        int iCantidadCuotas;
        Cliente iCliente;

        public SolicitudPrestamo (Cliente pCliente , double pMonto , int pCantidadCuotas)
        {
            this.iMonto = pMonto;
            this.iCantidadCuotas = pCantidadCuotas;
            this.iCliente = pCliente;
        }

        public double Monto
        {
            get
            {
                return this.iMonto;
            }
        } 

        public int CantidadCuotas
        {
            get
            {
                return this.iCantidadCuotas;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return this.iCliente;
            }
        }
    }
}