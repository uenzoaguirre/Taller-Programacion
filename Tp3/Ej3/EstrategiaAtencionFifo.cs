using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej3
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

        public int CantidadPacientesEnEspera()
        {
            return fifo.Count;
        }
        public EstrategiaAtencionFifo()
        {
            this.fifo = new Queue<Paciente>();
        }
        
    }
}