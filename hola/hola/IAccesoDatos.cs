using hola;
using System.Collections;
using System.Collections.Generic;

namespace hola
{
    public interface IAccesoDatos
    {
        bool create(Persona persona);
        List read();
        bool update(Persona persona, int posicionPersona);
        bool delete(string Identidad);
    }
}