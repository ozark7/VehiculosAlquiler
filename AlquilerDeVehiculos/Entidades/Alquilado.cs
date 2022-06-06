using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alquilado
    {
        private String placa;
        private String persona;
        private double valorKilometro;
        private String fecha;
        public Alquilado(String placa,String persona,double valorKilometro,string fecha)
        {
            this.placa = placa;
            this.persona = persona;
            this.valorKilometro = valorKilometro;
            this.fecha = fecha;
        }
        public Alquilado()
        {

        }
        public string Placa { get; set; }
        public string Persona { get; set; }
        public double ValorKilometro { get; set; }
        public string Fecha { get; set; }

        public String ToString()
        {
            return Placa+";"+Persona+";"+ValorKilometro+";"+Fecha;
        }
    }
}
