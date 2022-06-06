using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private String nombre;
        private string id;



        public Persona() { }
        public Persona(String nombre,string id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public String Nombre { get; set; }
        public String Id { get; set; }

        public String ToString()
        {
            return Nombre+";"+Id;
        }
    }
}
