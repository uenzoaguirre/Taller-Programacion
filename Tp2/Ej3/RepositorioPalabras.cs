using System;
using System.Collections.Generic;


namespace Ej3
{
    class RepositorioPalabras
    {
        Random iGeneradorNumeros; 
        string[] iPalabras;
        
        public RepositorioPalabras()
        {
            this.iPalabras =  new string[] {"Barco" , "Enzo" , "Calculadora" , "Pelota" , "Matriz" , "Derivada" , "Integrales" , "Electrocardiograma" , "Messi" , "Patineta" , "Numeros" , "Galletitas" , "Mate" , "Divisibilidad" , "Television" , "Programacion" , "Lapicera" , "Rupestre" , "Guardabosque" , "instagram" , "Arquitectura" , "Discreta" , "Sintaxis" , "Algebra" , "Quimica" , "Inteligencia Artificial" , "Fisica" , "Rapallini"};
            this.iGeneradorNumeros = new Random(); 
        }   

        public string ObtenerAleatoriamente() 
        {
            int posicion = this.iGeneradorNumeros.Next (0,this.iPalabras.Length);  
            return this.iPalabras[posicion];
            
        }
    }

}