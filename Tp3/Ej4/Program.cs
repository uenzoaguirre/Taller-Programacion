using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();

            Console.WriteLine("Seleccione una opción: \n 1.Encriptar \n 2.Desencriptar");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1) 
            {
                Console.WriteLine("Ingrese cadena a encriptar: ");
                string cadena = Console.ReadLine();
                Console.WriteLine(@"Seleccione una opción de algoritmo para encriptar: 
                1.AES
                2.Blowfish
                3.Cesar
                4.DES" );
                int opcion2 = Convert.ToInt32(Console.ReadLine());
                string CadenaEncriptada="";
                switch (opcion2)
                {
                    case 1: CadenaEncriptada=fachada.EncriptarAES(cadena);
                    break;
                    case 2: CadenaEncriptada=fachada.EncriptarBlowFish(cadena);
                    break;
                    case 3: CadenaEncriptada=fachada.EncriptarCesar(cadena);
                    break;  
                    case 4: CadenaEncriptada=fachada.EncriptarDES(cadena);
                    break;                
                }
                Console.WriteLine("La cadena encriptada es: {0}", CadenaEncriptada);
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Ingrese cadena a desencriptar: ");
                string cadena = Console.ReadLine();
                Console.WriteLine(@"Seleccione una opción de algoritmo para desencriptar: 
                1.AES
                2.Blowfish
                3.Cesar
                4.DES" );
                int opcion2 = Convert.ToInt32(Console.ReadLine());
                string CadenaDesincriptada="";
                switch (opcion2)
                {
                    case 1: CadenaDesincriptada=fachada.DesencriptarAES(cadena);
                    break;
                    case 2: CadenaDesincriptada=fachada.DesencriptarBlowFish(cadena);
                    break;
                    case 3: CadenaDesincriptada=fachada.DesencriptarCesar(cadena);
                    break;  
                    case 4: CadenaDesincriptada=fachada.DesencriptarDES(cadena);
                    break;                
                }
                Console.WriteLine("La cadena desencriptada: {0}", CadenaDesincriptada);
                Console.ReadLine();
            }
        }
    }
}
