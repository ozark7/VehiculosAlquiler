using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Logica
{public class ServicioVehiculos
    {
        List<Vehiculo> lista = new List<Vehiculo>();
        public ServicioVehiculos()
        {
            lista = new RepositorioVehiculos().Consultar();
        }
        void Actualizar()
        {
            lista = new RepositorioVehiculos().Consultar();
        }
        public string Guardar(Vehiculo persona)
        {
            //validar
            return new RepositorioVehiculos().Guardar(persona);
        }
        public List<Vehiculo> Consultar()
        {
            Actualizar();
            return lista;
        }
        public Vehiculo Buscar(string placa)
        {
            foreach (var item in lista)
            {
                if (item.Placa == placa)
                {
                    return item;
                }
            }
            return null;
        }
        public String Modificar()
        {
            return new RepositorioVehiculos().Modificar(lista);
        }
    }
}
