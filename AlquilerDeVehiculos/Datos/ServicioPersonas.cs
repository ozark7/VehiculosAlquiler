using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Logica
{
    public class ServicioPersonas
    {
        List<Persona> lista = new List<Persona>();
        public ServicioPersonas()
        {
            lista = new RepositorioPersonas().Consultar();
        }
        void Actualizar()
        {
            lista = new RepositorioPersonas().Consultar();
        }
        public string Guardar(Persona persona)
        {
            //validar
            return new RepositorioPersonas().Guardar(persona);
        }
        public List<Persona> Consultar()
        {
            Actualizar();
            return lista;
        }
        public Persona BuscarId(string id)
        {
            foreach (var item in lista)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public String Modificar()
        {
            return new RepositorioPersonas().Modificar(lista);
        }
    }
}
