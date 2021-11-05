using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej3
{
    public class Usuario : IEquatable<Usuario>
    {
        string iCodigo;
        string iNombreCompleto;
        string iCorreoElectronico;

        public string Codigo
        {
            get
            {
                return this.iCodigo;
            }
            set
            {
                this.iCodigo = value;
            }
        }
        public string NombreCompleto
        {
            get
            {
                return this.iNombreCompleto;
            }
            set
            {
                this.iNombreCompleto = value;
            }
        }
        public string CorreoElectronico
        {
            get
            {
                return this.iCorreoElectronico;
            }
            set
            {
                this.iCorreoElectronico = value;
            }
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Usuario);
        }

        public bool Equals(Usuario other)
        {
            return other != null &&
                  this.Codigo == other.Codigo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Codigo);
        }
    }
}