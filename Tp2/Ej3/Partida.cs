using System;
using System.Globalization;
using System.Collections.Generic;
    namespace Ej3
    {
        class Partida
        {
            string iNombreJugador;
            int iEdadJugador;
            DateTime iFechaHoraInicio;
            DateTime iFechaHoraFin;
            bool iHaGanado;
            string iId;

            AdministradorPalabras iAdminpalabra;

        int iCantidadMaximaErrores;


        public Partida(string pNombre, int pEdadJugador, string pId, string pPalabra , int pCantidadMaximaErrores)
        {
            this.iNombreJugador = pNombre;
            this.iEdadJugador = pEdadJugador;
            this.iFechaHoraInicio = DateTime.Now;
            this.iId = pId;
            this.iAdminpalabra = new AdministradorPalabras(pPalabra);
            this.iCantidadMaximaErrores = pCantidadMaximaErrores;
        }

            public string Nombre
            {
                get {return this.iNombreJugador;}
            }

            public int Edad 
            {
                get {return this.iEdadJugador;}
            }

            public DateTime FechaHoraInicio
            {
                get {return this.iFechaHoraInicio;}
            }

            public DateTime FechaHoraFin
            {
                get {return this.iFechaHoraFin;}
            }

            public bool HaGanado 
            {
                get {return this.iHaGanado;}
            }

            public string Id 
            {
            get { return this.iId;}
            }

            public double TiempoEmpleado
            {
                get {return (this.iFechaHoraFin - this.iFechaHoraInicio).Seconds;}
            }

             public int Errores
            {
                get {return this.iAdminpalabra.Errores;}
            }            

            public void Finalizar()
            {
                this.iHaGanado = this.VerificarSigano();
                this.iFechaHoraFin = DateTime.Now;
            }

            public List<CaracterIndice> VerificarLetra(char pLetra)
            {
            return this.iAdminpalabra.VerificarLetra(pLetra);
            }

            public bool VerificarSigano()
            {
            return this.iAdminpalabra.VerificarSigano();
            }

            public string Palabra
            {
            get { return this.iAdminpalabra.Palabra; }
            }

             public bool VerificarSiperdio()
            {
            return (this.iAdminpalabra.Errores >= this.iCantidadMaximaErrores);
            }
        



        }
    }

