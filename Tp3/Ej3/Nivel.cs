using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tp3.Ej3
{
    public class Nivel
    {
        int numero;
        string categoria;
        string color;
        Queue<Paciente> fifo;
        public Nivel(int pnumero, string pcategoria, string pcolor)
        {
            this.numero= pnumero;
            this.categoria= pcategoria;
            this.color= pcolor;
            
            
        }
        public void Agregar(Paciente paciente )
        {
            fifo.Enqueue(paciente);





        }

        public Paciente Obtener()
        {
           return fifo.Dequeue();

        }
        

    



        
    }
}