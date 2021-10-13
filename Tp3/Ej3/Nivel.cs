using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ej3
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
            this.fifo = new Queue<Paciente>();
            
            
        }
        public void Agregar(Paciente paciente )
        {
            fifo.Enqueue(paciente);
        }


        public Paciente Obtener()
        {
           return fifo.Dequeue();

        }

        public int CantidadDeElementos()
        {
            return fifo.Count;
        }
        

    



        
    }
}