using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej3
{
    public class PacienteEnEspera
    {
        int nivel;
        Paciente paciente;

    public PacienteEnEspera (Paciente pPaciente, int pNivel)
    {
        this.paciente = pPaciente;
        this.nivel = pNivel;
    } 
        public int  Nivel
        {get{return this.nivel;}

        }
        public Paciente Paciente
        {get{return this.paciente;}
        }
    }
}