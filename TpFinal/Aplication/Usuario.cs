using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Usuario
    {
        // FIX: Agregar pPrestamos al ctor en el diagrama
        public Usuario(int pDni, string pNombreUsuario, string pPassword, string pMail, DateTime pFechaRegistro, int pPuntaje, List<Prestamo> pPrestamos) {
            this.dni = pDni;
            this.nombreUsuario = pNombreUsuario;
            this.password = pPassword;
            this.mail = pMail;
            this.fechaRegistro = pFechaRegistro;
            this.puntaje = pPuntaje;
            this.prestamos = pPrestamos;
        }

        // FIX: En el diagrama aparece como una property pero es una funcion
        public void AumentarPuntaje(int pExtra) {
            this.puntaje += pExtra;
        }

        public void ReducirPuntaje(int pExtra) {
            this.puntaje -= pExtra;
        }

        public int Dni
        {
            get { return dni; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }

        }

        public string Password
        {
            get { return password; }
        
        }
        
        public string Mail
        {
            get { return mail; }
            
        }
        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            
        }

        public int Puntaje
        {
            get { return puntaje; }
        }

        public List<Prestamo> Prestamos
        {
            get { return prestamos; }
        }
        
        private DateTime fechaRegistro;

        private int puntaje;

        private string mail;

        private string password;

        private int dni;

        private string nombreUsuario;

        // FIX: Agregarle el nombre en el diagrama
        List<Prestamo> prestamos;
    }
}