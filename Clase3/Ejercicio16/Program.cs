using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Oggioni","Ezequiel");
            Alumno alumnoDos = new Alumno("Dillon", "Horacio");
            Alumno alumnoTres = new Alumno("Davila", "Federico");
            Alumno alumnocuatro = new Alumno("Abuliño", "Pebeton");

      alumno1.apellido = "Perez";
            alumno1.Estudiar(10, 10);
            alumnoDos.Estudiar(4, 4);
            alumnoTres.Estudiar(10, 1);
      alumnocuatro.Estudiar(10, 2);

            alumno1.CalcularFinal();
            alumnoDos.CalcularFinal();
            alumnoTres.CalcularFinal();
      alumnocuatro.CalcularFinal();


            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());
      Console.WriteLine(alumnocuatro.Mostrar());

      Console.ReadKey();


        }
    }
}
