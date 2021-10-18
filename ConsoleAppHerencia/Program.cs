using System;


namespace ConsleAppHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1;
            p1 = new persona();
            Console.Write("ingrese el nombre de la persona: ");
            p1.Nombre = Console.ReadLine();
            Console.Write("ingrese la fecha de nacimiento de la persona: ");
            p1.FechaNacimiento = Console.ReadLine();
            Console.WriteLine(p1.ToString());

            Alumno a1;
            a1 = new Alumno();
            Console.Write("ingrese el nombre del alumno: ");
            a1.Nombre = Console.ReadLine();
            Console.Write("ingrese la fecha de nacimiento del alumno: ");
            a1.FechaNacimiento = Console.ReadLine();
            Console.Write("ingrese la carrera del alumno: ");
            a1.Carrera = Console.ReadLine();
            Console.Write("ingrese la matricula del alumno: ");
            a1.Matricula = Console.ReadLine();
            Console.WriteLine(a1.ToString());

            Console.ReadKey();

        }
    }
}