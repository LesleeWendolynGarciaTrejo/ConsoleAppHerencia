using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppHerencia
{
    class Persona
    {
        protected string fechaNacimiento;

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        protected string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Persona()
        {
            nombre = "";
            fechaNacimiento = "";
        }

        public Persona(string nombre, string fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nFecha de nacimiento: " + fechaNacimiento;
        }
    }
}