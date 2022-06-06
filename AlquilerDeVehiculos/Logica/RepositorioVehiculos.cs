using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;
namespace Datos
{
    public class RepositorioVehiculos
    {
        string ruta = "Vehiculos.txt";// ruta donde se guarda el archivo
        public string Guardar(Vehiculo vehiculo)
        {
            try
            {
                //FileStream archivo = new FileStream(ruta, FileMode.Append);
                //1. instanciar - abre en modo append -  adiciona datos
                StreamWriter escritor = new StreamWriter(ruta, true);

                // 2. operaciones
                escritor.WriteLine(vehiculo.ToString());

                //3.  guardar
                escritor.Close();

                return "Se guardaron los datos";
            }
            catch (Exception)
            {
                return "NO Se guardaron los datos";
            }

        }
        public string Modificar(List<Vehiculo> vehiculos)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(ruta, false);// sobreescribe
                foreach (var item in vehiculos)
                {
                    escritor.WriteLine(item.ToString());
                    //close
                }

                escritor.Close();

                return "Se modificaron los datos";

                //File.Delete(ruta);  // elimina
                //File.Move("tmp", ruta);// renombrar
            }
            catch (Exception)
            {

                return "NO Se guardaron los datos";
            }

        }
        public Vehiculo BuscarPlaca(string placa)
        {
            List<Vehiculo> vehiculos = Consultar();
            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Placa == placa)
                {
                    return vehiculo;
                }
            }
            return null;
        }
        public List<Vehiculo> Consultar()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Vehiculo> vehiculos = new List<Vehiculo>();
                // 2. operaciones
                string linea = string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    string placa = (linea.Split(';')[0]);
                    double kilometraje = double.Parse(linea.Split(';')[1]);
                    bool estado;
                    if (linea.Split(';')[2].Equals("Listo")) { estado = true; }
                    else { estado = false; }

                    Vehiculo vehiculo = new Vehiculo(placa, kilometraje, estado);
                    vehiculos.Add(vehiculo);
                }

                //3.  guardar
                lector.Close();

                return vehiculos;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<Vehiculo> Consultar2()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Vehiculo> vehiculos = new List<Vehiculo>();
                // 2. operaciones
                string linea = string.Empty;
                while (!lector.EndOfStream)
                {
                    linea = lector.ReadLine();
                    string placa =(linea.Split(';')[0]);

                    /*Persona persona;*/// = new RepositorioClientes().buscarId(linea.Split(';')[1]);
                    //if (new RepositorioPersonas().buscarId(linea.Split(';')[1]) == null)
                    //{
                    //    persona = new RepositorioPersonas().buscarId(linea.Split(';')[1]);
                    //}
                    //else
                    //{
                    //    persona = new RepositorioPersonas().buscarNombre(linea.Split(';')[1]);
                    //}
                    double kilometraje = double.Parse(linea.Split(';')[1]);
                    bool estado;
                    if (linea.Split(';')[2].Equals("Listo")) { estado = true; }
                    else { estado = false; }

                    Vehiculo vehiculo = new Vehiculo(placa,kilometraje,estado);
                    vehiculos.Add(vehiculo);
                }

                //3.  guardar
                lector.Close();

                return vehiculos;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
