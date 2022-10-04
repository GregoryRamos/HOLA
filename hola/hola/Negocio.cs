using System;
using System.Collections;
using System.Collections.Generic;

namespace hola
{
    public class Negocio
    {
        public void insertar()
        {
            Console.WriteLine("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese Id de identidad: ");
            string Identidad = Console.ReadLine();

            Console.WriteLine("Ingrese sexo: ");
            bool sexo = Console.ReadLine() == "M" ? true : false;

            Console.WriteLine("Ingrese fecha de nacimiento: ");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            

            Persona persona = new Persona();

            persona.nombre = nombre;
            persona.apellido = apellido;
            persona.Identidad = Identidad;
            persona.sexo = sexo;
            persona.fechaNacimiento = fechaNacimiento;
            persona.fechaRegistro = DateTime.Now;
            persona.fechaModificacion = DateTime.Now;

            IAccesoDatos iAccesoDatos = new AccesoDatos();

            if (iAccesoDatos.create(persona))
            {
                Console.WriteLine("Datos registrados correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo registrar los datos.");
            }
        }

        public void listar()
        {
            IAccesoDatos iAccesoDatos = new AccesoDatos();

            List listaPersona = iAccesoDatos.read();

            int i = 1;

            foreach (Persona item in listaPersona)
            {
                Console.WriteLine(string.Concat(i, ". ", item.nombre, "---", item.apellido, "---", item.sexo, "---", item.fechaNacimiento, "---", item.estatura, "---", item.fechaRegistro, "---", item.fechaModificacion));

                i++;
            }
        }

        public void editar()
        {
            listar();

            Console.WriteLine();
            Console.WriteLine("Ingrese el nro de la persona que desea editar:");
            int posicionPersona = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese Id de identidad: ");
            string Identidad = Console.ReadLine();

            Console.WriteLine("Ingrese sexo: ");
            bool sexo = Console.ReadLine() == "M" ? true : false;

            Console.WriteLine("Ingrese fecha de nacimiento: ");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

            
            Persona persona = new Persona();

            persona.nombre = nombre;
            persona.apellido = apellido;
            persona.Identidad = Identidad;
            persona.sexo = sexo;
            persona.fechaNacimiento = fechaNacimiento;
            persona.fechaModificacion = DateTime.Now;

            IAccesoDatos iAccesoDatos = new AccesoDatos();

            if (iAccesoDatos.update(persona, posicionPersona))
            {
                Console.WriteLine("Datos modificados correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo modificar los datos.");
            }
        }

        public void eliminar()
        {
            listar();

            Console.WriteLine();
            Console.WriteLine("Ingrese el Id de identidad de la persona que desea eliminar:");
            string Identidad = Console.ReadLine();

            IAccesoDatos iAccesoDatos = new AccesoDatos();

            if (iAccesoDatos.delete(Identidad))
            {
                Console.WriteLine("Persona eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo eliminar los datos porque la persona no existe.");
            }
        }
    }
}