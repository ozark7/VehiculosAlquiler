using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{public class Entregado
    {
        private String placa;
        private String persona;
        private double kilometraje;
        private double valorKilometro;
        private String fecha;
        public double valor;
        public Entregado(String placa, String persona,double kilometraje, double valorKilometro, string fecha, double valor)
        {
            this.placa = placa;
            this.persona = persona;
            this.kilometraje = kilometraje;
            this.valorKilometro = valorKilometro;
            this.fecha = fecha;
            this.valor = valor;
        }
        public Entregado()
        {

        }
        public string Placa { get; set; }
        public string Persona { get; set; }
        public double Kilometraje { get; set; }
        public double ValorKilometro { get; set; }
        public string Fecha { get; set; }
        public double Valor { get; set; }

        public String ToString()
        {
            return Placa + ";" + Kilometraje+";"+Persona + ";" + ValorKilometro + ";" + Fecha+";"+Valor;
        }
    }
}
