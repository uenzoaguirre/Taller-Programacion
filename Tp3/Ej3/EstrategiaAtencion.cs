using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej3
{
    public interface EstrategiaAtencion
    {
         void Agregar(PacienteEnEspera paciente);

         Paciente ObtenerPrioritario();

        int CantidadPacientesEnEspera();
        
    }
}