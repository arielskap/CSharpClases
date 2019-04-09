using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            if(operador=="+"||operador=="-"||operador=="/"||operador=="*")
            else
            {
                operador = "+";
            }
            return operador;
        }
        public double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado=0;
            operador = ValidarOperador(operador);
            switch(operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        resultado = 0;
                    }
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }
            return resultado;
        }
    }
}
