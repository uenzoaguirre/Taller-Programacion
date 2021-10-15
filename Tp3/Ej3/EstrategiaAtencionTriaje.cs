using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej3
{

    public class EstrategiaAtencionTriaje : EstrategiaAtencion
    {
        public Dictionary<int, Nivel> niveles;

        public EstrategiaAtencionTriaje()
        {
            this.niveles = new Dictionary<int, Nivel>();
            niveles.Add(1, new Nivel(1, "Atencion Inmediata", "rojo"));
            niveles.Add(2, new Nivel(2, "Emergencia", "anaranjado"));
            niveles.Add(3, new Nivel(3, "Urgente", "amarillo"));
            niveles.Add(4, new Nivel(4, "Menos Urgente", "verde"));
            niveles.Add(5, new Nivel(5, "No Urgente", "azul"));
        }
        public void Agregar(PacienteEnEspera paciente)
        {
            if (niveles.ContainsKey(paciente.Nivel))
            {
                niveles[paciente.Nivel].Agregar(paciente.Paciente);

            }



        }

        public int CantidadPacientesEnEspera()
        {
            int elem = 0;

            for (int i = 1; i < 6; i++)
            {
                elem = elem + niveles[i].CantidadDeElementos();
            }
            return elem;
        }
        public Paciente ObtenerPrioritario()
        {
            //Recorrer todos los niveles desde mas urgente al menos urgente   
            // y si tiene un elemento obtenerlo y devolverlo 

            for (int i = 1; i < 6; i++)
            {
                if (niveles[i].CantidadDeElementos() > 0)
                {
                    return niveles[i].Obtener();
                }
            }
            return null;
        }


    }
}