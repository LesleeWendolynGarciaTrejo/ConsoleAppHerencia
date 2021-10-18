using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHerencia
{
    class Alumno : Persona
    {
        private string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        private string carrera;

        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public Alumno() : base()
        {
            matricula = "";
            carrera = "";
        }
        public Alumno(string nombre, string fechaNacimiento, double matricula, string carrera) : base(nombre, fechaNacimiento)
        {
            this.matricula = Matricula;
            this.carrera = carrera;
        }
        public override string ToString()
        {
            return base.ToString() + "  Matricula:" + matricula + "  Carrera:" + carrera;

        }
    }
}