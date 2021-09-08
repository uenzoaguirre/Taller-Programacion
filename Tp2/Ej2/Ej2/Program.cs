using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fachada fachada = new Fachada();
            while (true)
            {
            Console.WriteLine("Seleccionar una opcion");
            Console.WriteLine("1. Crear cuenta unificada \n2. Realizar operaciones");
            int numero = Convert.ToInt32 (Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Ingrese DNI: ");
                string DNI = Console.ReadLine();
                Console.WriteLine("Ingrese Nombre del titular: "); 
                string nombre = Console.ReadLine();
                fachada.CrearCuentaUnificada(DNI,nombre);
            } else
            {
                Console.WriteLine("Ingrese DNI: ");
                string DNI = Console.ReadLine();

                Console.WriteLine("1. Selecionar cuenta en peso:\n2. Selecionar cuenta en dolar: ");
                 numero = Convert.ToInt32 (Console.ReadLine());
                 Console.WriteLine("1. Debitar \n2. Acreditar \n3. Consultar Saldo \n4. Transferir ");
                int numero1 = Convert.ToInt32 (Console.ReadLine());
               
                double monto = 0;
                if (numero1 == 1 || numero1 == 2 || numero1 == 4) 
                {
                    Console.WriteLine("Ingrese monto: "); 
                    monto = Convert.ToDouble (Console.ReadLine());    
                }    

                 if (numero == 1)
                 {
                     if (numero1 == 1)
                     {  
                        fachada.DebitarEnCuentaPesos (DNI, monto);
                     } 
                     else if (numero1 == 2)
                    {
                        fachada.AcreditarEnCuentaPesos (DNI, monto);
                    } 
                     else if (numero1 == 3)
                    {
                       double saldo = fachada.ConsultarSaldoEnPesos (DNI);
                       Console.WriteLine ("Saldo: {0}", saldo );
                    }
                     else 
                    {
                        if (! fachada.TransferirPesosADolar (DNI, monto))  //! para negar
                        {
                         Console.WriteLine ("Transferencia no se pudo realizar");   
                        } else
                         {
                            Console.WriteLine ("Transferencia Exitosa!"); 
                         }
                        
                    }
                 } 
                    else 
                    {
                        if (numero1 == 1)
                     {  
                        fachada.DebitarEnCuentaDolares (DNI, monto);
                     } 
                     else if (numero1 == 2)
                    {
                        fachada.AcreditarEnCuentaDolares (DNI, monto);
                    }  else if (numero1 == 3)
                    {
                        double saldo = fachada.ConsultarSaldoEnDolares (DNI);
                        Console.WriteLine ("Saldo: {0}", saldo );
                    } else 
                    {
                        if (! fachada.TransferirDolaresAPesos (DNI, monto))  //! para negar
                        {
                         Console.WriteLine ("Transferencia no se pudo realizar");   
                        } else
                         {
                            Console.WriteLine ("Transferencia Exitosa!"); 
                         } 
                    }
                }
             }

            }
        }
    }
}
