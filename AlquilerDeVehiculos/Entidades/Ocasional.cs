using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Ocasional:Persona
    {

        public Ocasional()
        {
            
        }
        public string ToString()
        {

            return Nombre + ";" + Id + ";" + "Ocasional";
        }
    }
}
