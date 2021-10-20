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
           if (fifo.Count > 0)
            {
                return fifo.Dequeue();
            } 
            else {
                return null;
            }
                
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