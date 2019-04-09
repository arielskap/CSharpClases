using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;
        public Numero()
        {
            this.numero = 0;
        }
        public Numero(double numero)
        {
            this.numero = numero;
        }
        public Numero(string numero)
        {
            this.SetNumero(numero);
        }
        private static double ValidarNumero(string strNumero)
        {
            double numerico;
            if(double.TryParse(strNumero,out numerico))
            { }
            else
            {
                numerico = 0;
            }
            return numerico;
        }
        private void SetNumero(string numero)
        {
            this.numero = ValidarNumero(numero);
        }
        public static string BinarioDecimal(string binario)
        {
            return binario;
        }
        public static string DecimalBinario(double numero)
        {
            string numeroString="";
            return numeroString;
        }
        public static string DecimalBinario(string numero)
        {
            return numero;
        }
        public static double operator -(Numero n1,Numero n2)
        {
            double resultado;
            resultado = n1.numero - n2.numero;
            return resultado;
        }
        public static double operator *(Numero n1,Numero n2)
        {
            double resultado;
            resultado = n1.numero * n2.numero;
            return resultado;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numero / n2.numero;
            return resultado;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numero + n2.numero;
            return resultado;
        }
        //hacer sobrecargar de == y !=

        /*public static Numero operator ==()
        {

        }*/
    }
}
