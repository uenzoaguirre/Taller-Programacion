using System;

namespace Ej3
{
    class Program
    {
        // TODO: fachada permita consulta cuantos pacientes quedan por atender
        // arreglar el error de que no se vacian las colas de urgencia
        // testiar el agregar en urgencias y consultas 
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();

            string[] nombres = new string[]
            {
                "Juan","Pedro","Jose","Pascal",
                "Ivan","Enzo","Sofia","Josefina",
                "Hernan","Lihuen","Julio","Nico",
                "Heraldo","Agustin","Lucas","Brian",
                "Santiago","Franchesco","Javier","Omar"
            };
            for (int i = 0; i < 10; i++)
            {

                fachada.AgregarPacienteAConsultas(nombres[i]);

            }
            for (int j = 1; j < 6; j++)
            {
                for (int i = 10; i < 20; i++)
                {
                    fachada.AgregarPacienteAUrgencias(nombres[i], j);
                }
            }
            while (true)
            {


                Console.WriteLine("Seleccione una operacion: \n 1.Agregar \n 2.Obtener");
                int opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Seleccione una sala: \n 1.Urgencia \n 2.Consulta");
                int opcionSala = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese nombre de paciente a agregar: ");
                    string nombre = Console.ReadLine();

                    if (opcionSala == 1)
                    {
                        Console.WriteLine(@"Ingrese nivel: 
                o Nivel 1 (rojo): atención inmediata.
                o Nivel 2 (anaranjado): emergencia.
                o Nivel 3 (amarillo): urgente.
                o Nivel 4 (verde): menos urgente.   
                o Nivel 5 (azul): no urgente");
                        int nivel = Convert.ToInt32(Console.ReadLine());

                        if (nivel > 5 || nivel < 1)
                        {
                            Console.WriteLine("Nivel ingresado invalido");
                        }
                        else
                        { fachada.AgregarPacienteAUrgencias(nombre, nivel); }
                    }
                    else
                    {
                        fachada.AgregarPacienteAConsultas(nombre);
                    }
                }
                else
                {
                    if (opcionSala == 1)
                    {
                        string nombre = fachada.ObtenerPacienteDeUrgencia();
                        Console.WriteLine("Nombre: {0}", nombre);
                    }
                    else
                    {
                        string nombre = fachada.ObtenerPacienteDeConsulta();
                        Console.WriteLine("Nombre: {0}", nombre);
                    }
                }

            }

        }
    }
}