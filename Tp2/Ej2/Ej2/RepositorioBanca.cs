using System;
using System.Collections.Generic;
namespace Ej2
{
    class RepositorioBanca
    {
        List<Banca> iBancas;     //Lista del tipo banca   

    //Constructor
        public RepositorioBanca ()
        {
            this.iBancas = new List<Banca>();
        }

    //Asumimos que la banca ya existe
         public Banca Obtener (string pNumero)  
         {
            foreach (Banca banca in this.iBancas) 
            {
                if (banca.Numero == pNumero)
                {
                   return banca; 
                } 
            } 
            return null;
         }

        public void Agregar (Banca pBanca)
        {
            iBancas.Add (pBanca);
        }
        
    }
}