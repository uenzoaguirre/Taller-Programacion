using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class Fachada
    {
        GestorPrestamos gestor = new GestorPrestamos();
        List<Cliente> clientes = new List<Cliente>();
        public void AgregarCliente(DTOCliente dCliente)
        {
            Empleo pEmpleo = new Empleo(dCliente.Sueldo, dCliente.FechaIngreso);
            Cliente pCliente = new Cliente(dCliente.Nombre, dCliente.Apellido, dCliente.FechaNacimiento, pEmpleo);
            clientes.Add(pCliente);
        }

        public bool EvaluarPrestamo(DTOSolicitudPrestamo dSolicitud, string pNombreCliente, string pApellidoCliente)
        {
            var cliente = clientes.Find(pCliente => pCliente.Nombre == pNombreCliente && pCliente.Apellido == pApellidoCliente);
            if (cliente != null)
            {
                SolicitudPrestamo pSolicitud = new SolicitudPrestamo(cliente, dSolicitud.Monto, dSolicitud.CantidadCuotas);
                return gestor.EsValida(pSolicitud);
            }
            return false;
        }

    }

}
