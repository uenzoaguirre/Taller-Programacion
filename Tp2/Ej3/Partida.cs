using System;
using System.Globalization;

    namespace Ej3
    {
        class Partida
        {
            string iNombreJugador;
            int iEdadJugador;
            DateTime iFechaHoraInicio;
            DateTime iFechaHoraFin;
            bool iResultado;

            public Partida(string pNombre , int pEdadJugador)
            {
                this.iNombreJugador = pNombre;
                this.iEdadJugador = pEdadJugador;
                this.iFechaInicio = DateTime.Now;
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
                get {this.iResultado = false;}
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

