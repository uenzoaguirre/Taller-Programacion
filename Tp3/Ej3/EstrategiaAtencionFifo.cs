using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tp3.Ej3
{
    
    public class EstrategiaAtencionFifo: EstrategiaAtencion
    {
        Queue<Paciente> fifo;
      
        public void Agregar(PacienteEnEspera paciente)
        {
            fifo.Enqueue(paciente.Paciente);

        }
        public Paciente ObtenerPrioritario()
        {
            return fifo.Dequeue();
            
        }
        
        
    }
}