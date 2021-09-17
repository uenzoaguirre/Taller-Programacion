using System;
using System.Globalization;

    namespace Ej3
    {
        class Partida: AdministradorPalabras
        {
            string iNombreJugador;
            int iEdadJugador;
            DateTime iFechaHoraInicio;
            DateTime iFechaHoraFin;
            bool iResultado;
            string iId;

        public Partida(string pNombre , int pEdadJugador, string pId , string pPalabra): base(pPalabra)
            {
                this.iNombreJugador = pNombre;
                this.iEdadJugador = pEdadJugador;
                this.iFechaHoraInicio = DateTime.Now;
                this.iId = pId;
                
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

            public bool Resultado 
            {
                get {return this.iResultado = false;}
            }

            public string Id 
            {
            get { return this.iId;}
            }

            public double TiempoEmpleado
            {
                get {return (this.iFechaHoraFin - this.iFechaHoraInicio).Seconds;}
            }

            public void Finalizar(bool pResultado)
            {
                this.iResultado = pResultado;
                this.iFechaHoraFin = DateTime.Now;
            }
        



        }
    }

