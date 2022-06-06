using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;
namespace Datos
{
    public class RepositorioPersonas
    {
        string ruta = "Personas.txt";// ruta donde se guarda el archivo
        public string Guardar(Persona persona)
        {
            try
            {
                //1. instanciar - abre en modo append -  adiciona datos
                StreamWriter escritor = new StreamWriter(ruta, true);
                // 2. operaciones
                escritor.WriteLine(persona.ToString());
                //3.  guardar
                escritor.Close();
                return "Se guardaron los datos";
            }
            catch (Exception)
            {
                return "NO Se guardaron los datos";
            }
        }
        public string Modificar(List<Persona> clientes)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, false);// sobreescribe
                foreach (var item in clientes)
                {
                    escritor.WriteLine(item.ToString());
                }
                escritor.Close();
                return "Se modificaron los datos los datos";
            }
            catch (Exception)
            {
                return "NO Se guardaron los datos";
            }
        }
        public List<Persona> Consultar()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Persona> personas = new List<Persona>();
                string linea = string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    Persona persona = new Persona();
                    persona.Id = Convert.ToString(linea.Split(';')[0]);
                    persona.Nombre = linea.Split(';')[1];
                    personas.Add(persona);
                }
                lector.Close();
                return personas;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Persona buscarId(string id)
        {
            foreach (var item in Consultar())
            {
                if (item.Id.Equals(id))
                {
                    return item;
                }
            }
            return null;
        }
        public Persona buscarNombre(string nombre)
        {
            foreach (var item in Consultar())
            {
                if (item.Nombre == nombre)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
