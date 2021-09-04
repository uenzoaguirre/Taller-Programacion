using System;

namespace Ej7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cadena 1 con letras o numeros sin el 0: ");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("Ingrese cadena 2 con letras o numeros sin el 0: ");
            string cadena2 = Console.ReadLine();
            
            bool esanagrama = false;
            if (cadena1.Length == cadena2.Length)
            {
                esanagrama = true;
                for (int i = 0; i < cadena1.Length; i++)
                {
                    for (int j = 0; j < cadena2.Length; j++)
                    {
                        if (cadena1[i] == cadena2[j])
                        {
                            cadena2 = cadena2.Remove(j, 1);
                            cadena2 = cadena2.Insert(j, "0");
                            break;
                        }
                        else if (j == cadena2.Length - 1)
                        {
                            esanagrama = false;
                        }
                    }
                }
            }
            if (esanagrama == false)
            {
                Console.WriteLine("No es anagrama");
            }
            else
            {
                Console.WriteLine("Es anagrama");
            }

        }
    }
}
