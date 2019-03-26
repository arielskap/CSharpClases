using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        public static string colegio;
        static Random rnd;

        public Alumno(string apellido, string  nombre)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.notaFinal = -1;
        }

        static Alumno()
        {
            colegio = "UTN";
            rnd = new Random();
        }


        public void CalcularFinal()
        {
            if (this.nota1 > 3 && this.nota2 > 3)
            {
                this.notaFinal = rnd.Next(1, 10);
            }
            else
                this.notaFinal = -1;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;

        }

        public string Mostrar()
        {        
            return this.legajo.ToString() + "-" +  this.apellido + " " + 
                this.nombre + " " + colegio  +  " " + 
                (this.notaFinal == -1 ? "DESAPROBADO": this.notaFinal.ToString()) ;
        }

    }
}
