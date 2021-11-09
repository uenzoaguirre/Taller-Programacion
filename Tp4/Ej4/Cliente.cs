using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej4
{
    public class Cliente
    {
        string iNombre;
        string iApellido;

        DateTime iFechaNacimiento;

        Empleo iEmpleo;

        TipoCliente iTipo;

        public  Cliente(string pNombre , string pApellido , DateTime pFechaNacimiento , Empleo pEmpleo)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iFechaNacimiento = pFechaNacimiento;
            this.iEmpleo = pEmpleo;
        } 

        public string Nombre
        {
            get 
            { 
                return this.iNombre; 
            }
        }

        public string Apellido
        {
            get
            {
                return this.iApellido;
            }
        }

        public DateTime FechaNacimiento 
        {
            get
            {
                return this.iFechaNacimiento;
            }
        }

        public TipoCliente Tipo
        {
            get 
            {
                return this.iTipo;
            }
            set 
            {
                iTipo = value;
            }
        }

      
      public Empleo Empleo
        {
            get 
            {
                return this.iEmpleo;
            }
            set 
        {









    }
}