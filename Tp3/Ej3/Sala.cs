using System;

namespace Ej3
{
    class Sala
    {
        string nombre;

        EstrategiaAtencion estrategia;
        public string Nombre
        {
            get {return this.nombre; }
        }  

        public Sala (EstrategiaAtencion pEstrategia, string pNombre)
        {
           this.estrategia = pEstrategia;  
           this.nombre = pNombre;
        }

        public void AgregarPaciente(PacienteEnEspera paciente)
        {
            this.estrategia.Agregar(paciente);
        }

        public Paciente ObtenerPaciente()
        {
            return estrategia.ObtenerPrioritario();
        }
    }

}
