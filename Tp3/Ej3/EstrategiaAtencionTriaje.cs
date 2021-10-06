using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tp3.Ej3
{
    
    public class EstrategiaAtencionTriaje: EstrategiaAtencion
    {
        public Dictionary<int, Nivel> niveles;

        public EstrategiaAtencionTriaje()
        {
            niveles.Add(1, new Nivel(1,"Atencion Inmediata","rojo"));
            niveles.Add(2, new Nivel(2,"Emergencia","anaranjado"));
            niveles.Add(3, new Nivel(3,"Urgente","amarillo"));
            niveles.Add(4, new Nivel(4,"Menos Urgente","verde"));
            niveles.Add(5, new Nivel(5,"No Urgente","azul"));
        }
        public void Agregar(PacienteEnEspera paciente)
        {
            if(niveles.ContainsKey(paciente.Nivel))
            { niveles[paciente.Nivel].Agregar(paciente.Paciente);

            }
            
            

        }
        public Paciente ObtenerPrioritario()
        {

        }
        
        
    }
}