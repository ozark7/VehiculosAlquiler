using System;

namespace Entidades
{
    public class Vehiculo
    {
        private String placa;
        private bool estado; //Permite saber si puede alquilarse o no un vehiculo
        private double kilometraje;
        private Persona persona;
        private double precioKilometraje;

        public Vehiculo()
        {
            this.Estado = true;
        }
        public Vehiculo(String placa,double kilometraje)
        {
            this.Estado = true;
            this.Placa = placa;
            this.Kilometraje=kilometraje;
        }
        public Vehiculo(String placa, double kilometraje,bool estado)
        {
            this.Estado = estado;
            this.Placa = placa;
            this.Kilometraje = kilometraje;
        }
        public String Placa { get; set; }
        public bool Estado { get; set; }
        public double Kilometraje { get; set; }

        public String ToString()
        {
            string estado=string.Empty;
            if (this.Estado) { estado="Listo"; }
            else{ estado = "Alquilado"; }
            return Placa + ";" + Kilometraje + ";" + estado;
        }
    }
}
