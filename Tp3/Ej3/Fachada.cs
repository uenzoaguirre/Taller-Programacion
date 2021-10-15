using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej3
{
    public class Fachada
    {
        Sala salaUrgencia;
        Sala salaConsulta;

        public Fachada()
        {
            salaUrgencia = new Sala(new EstrategiaAtencionTriaje(),"Urgencia");
            salaConsulta = new Sala(new EstrategiaAtencionFifo(),"Consulta");
        }

        public void AgregarPacienteAUrgencias(string pNombre, int pNivel)
        {
            Paciente paciente = new Paciente(pNombre);
            PacienteEnEspera pacienteEnEspera = new PacienteEnEspera(paciente,pNivel);
             salaUrgencia.AgregarPaciente(pacienteEnEspera); 
        }

          public void AgregarPacienteAConsultas(string pNombre)
        {
            Paciente paciente = new Paciente(pNombre);
            PacienteEnEspera pacienteEnEspera = new PacienteEnEspera(paciente,0);
            salaConsulta.AgregarPaciente(pacienteEnEspera); 
        }

        public string ObtenerPacienteDeUrgencia()
        {
            return salaUrgencia.ObtenerPaciente().Nombre;
        }
        public string ObtenerPacienteDeConsulta()
        {
            return salaConsulta.ObtenerPaciente().Nombre;
        }

        public int CantidadPacientesUrgencia()
        {
            return salaUrgencia.CantidadPacientesEnEspera();
        }

        public int CantidadPacientesConsulta()
        {
            return salaConsulta.CantidadPacientesEnEspera();
        }

    }
}