using System;

namespace hola
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opcionSeleccionada = 0;
            int x;

            Negocio negocio = new Negocio();

            while (opcionSeleccionada != 5)
            {
                Console.WriteLine("1. Insertar persona.");
                Console.WriteLine("2. Listar personas.");
                Console.WriteLine("3. Editar persona.");
                Console.WriteLine("4. Eliminar persona.");
                Console.WriteLine("5. Salir.");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Ingrese una opción:");

                string opcionSeleccionadaTemporal = Console.ReadLine();

                if (int.TryParse(opcionSeleccionadaTemporal, out x))
                {
                    opcionSeleccionada = int.Parse(opcionSeleccionadaTemporal);

                    switch (opcionSeleccionada)
                    {
                        case 1:
                            negocio.insertar();

                            break;
                        case 2:
                            negocio.listar();

                            break;
                        case 3:
                            negocio.editar();

                            break;
                        case 4:
                            negocio.eliminar();

                            break;
                        case 5:

                            break;

                        default:
                            Console.WriteLine("La opción asignada no está definida en el menú.");

                            break;
                    }
                }
                else
                {
                    opcionSeleccionada = 0;

                    Console.WriteLine("El valor ingresado no es correcto");
                }

                if (opcionSeleccionada != 5)
                {
                    Console.ReadLine();
                }

                Console.Clear();
            }
        }
    }
}