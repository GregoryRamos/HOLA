
using System;
using System.Collections;
using System.Collections.Generic;

namespace hola
{
    public class AccesoDatos : IAccesoDatos
    {
        public bool create(Persona persona)
        {
            Datos.dataPersona.Add(persona);

            return true;
        }

        public bool delete(string Identidad)
        {
            int posicionPersona = 0;
            bool existePersona = false;

            foreach (Persona item in Datos.dataPersona)
            {
                if (item.Identidad == Identidad)
                {
                    existePersona = true;

                    break;
                }

                posicionPersona++;
            }

            if (existePersona)
            {
                Datos.dataPersona.RemoveAt(posicionPersona);

                return true;
            }
            else
            {
                return false;
            }
        }

        public List read()
        {
            return Datos.dataPersona;
        }

        public bool update(Persona persona, int posicionPersona)
        {
            Datos.dataPersona[posicionPersona - 1].nombre = persona.nombre;
            Datos.dataPersona[posicionPersona - 1].apellido = persona.apellido;
            Datos.dataPersona[posicionPersona - 1].Identidad = persona.Identidad;
            Datos.dataPersona[posicionPersona - 1].sexo = persona.sexo;
            Datos.dataPersona[posicionPersona - 1].fechaNacimiento = persona.fechaNacimiento;
            Datos.dataPersona[posicionPersona - 1].fechaModificacion = persona.fechaModificacion;

            return true;
        }
    }
}
