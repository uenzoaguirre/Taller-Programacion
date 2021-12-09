using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class Obra
    {
        string titulo;
        string lccn;
        string descripcion;

        public string Titulo
        {
            get
            {
                return this.titulo;
            }
        }

        public string Lccn
        {
            get
            {
                return this.lccn;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        public Obra(string pTtiulo, string pLccn, string pDescripicon)
        {
            this.titulo = pTtiulo;
            this.lccn = pLccn;
            this.descripcion = pDescripicon;
        }


    }


}