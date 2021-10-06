using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tp3.Ej3
{
    public interface EstrategiaAtencion
    {
         void Agregar(PacienteEnEspera paciente);

         Paciente ObtenerPrioritario();
        

        
    }
}