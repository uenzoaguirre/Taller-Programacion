﻿using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            var gato = new Gato();
            var perro = new Perro();
            var veterinaria = new Veterinaria();
            Animal[] animales = new Animal[] { gato, perro };
            veterinaria.AceptarAnimales(animales);
        }
    }
}
