using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstClass1
{
  class Program
  {
    /*static int miEntero;
    static double miDouble = 20;
    static bool miBoolean;
    static string miPalabra;*/

    static void Main(string[] args)
    {
      /*
      //miEntero = miDouble; No se puede ya que hay perdidas de datos
      miEntero = (int)miDouble;
      //miEntero = (int) miPalabra;
      // alt+124  |
      // ctrl + k + d  Te acomoda las tabulaciones
      //miEntero = int.Parse(miPalabra);
      if (int.TryParse(miPalabra, out miEntero))
      {

      }
      miDouble = miEntero;
      miPalabra = miBoolean.ToString();
      System.Console.WriteLine(miPalabra);
      //ConsoleKeyInfo ck1 = Console.ReadKey();
      //Console.WriteLine(ck1.Key);
      //Console.ReadKey();
      //Console.BackgroundColor = ConsoleColor default;
      miPalabra = Console.ReadLine();
      //miEntero = int.Parse(miPalabra);
      if (int.TryParse(miPalabra, out miEntero))
      {
        switch (miEntero)
        {
          case 1:
            Console.WriteLine("Hola elejiste 1");
            Console.ReadKey();
            break;
          case 2:
            Console.WriteLine("Elejiste 2");
            Console.ReadKey();
            break;
          default:
            Console.WriteLine("Elejiste cualquier cosa");
            Console.ReadKey();
            break;
        }
      }
      else
      {
        Console.WriteLine("error");
        Console.ReadKey();
      }
      //miEntero = Convert.ToInt32(Console.ReadLine());
    }*/
      int operador, primerNumero, segundoNumero;
      Console.Write("Ingrese la opcion.\n");
      Console.Write("1. Sumar\n");
      Console.Write("2. restar\n");
      Console.Write("3. multiplicar\n");
      Console.Write("4. dividir\n");
      if (int.TryParse(Console.ReadLine(), out operador))
      {
        Console.Write("Ingrese 1er numero: ");
        if (int.TryParse(Console.ReadLine(), out primerNumero))
        {
          Console.Write("Ingrese 2do numero: ");
          if (int.TryParse(Console.ReadLine(), out segundoNumero))
          {
            miSwitch(operador, primerNumero, segundoNumero);
            Console.ReadKey();
          }
          else
          {
            Console.Write("ERROR");
          }
        }
        else
        {
          Console.Write("ERROR");
        }
      }
      else
      {
        Console.Write("ERROR");
      }
      //writeLine va en Main si o si. Esto es porque la idea es que las funciones sean lo logico osea el backEnd.
      //Mientras que lo que se muestra sea el frontEnd
    }
    static void miSwitch(int operador,int primerNumero,int segundoNumero)
    {
      Console.WriteLine("Resultado: ");
      switch(operador)
      {
        case 1:
          Console.WriteLine("la suma es "+primerNumero + segundoNumero);
          break;
        case 2:
          Console.WriteLine(primerNumero - segundoNumero);
          break;
        case 3:
          Console.WriteLine(primerNumero * segundoNumero);
          break;
        case 4:
          Console.WriteLine(primerNumero / segundoNumero);
          break;
        default:
            Console.Write("Opcion incorrecta.");
          break;
      }
    }
    /*static void calculadora(int valor)
    {
      string valor1;
      string valor2;
      int suma;
      switch(valor)
      {
        case 1:
          System.Console.WriteLine("1er numero");
          valor1 = Console.ReadLine();
          System.Console.WriteLine("2do numero");
          valor2 = Console.ReadLine();
          resultado = valor1 + valor2;
          Console.WriteLine("la suma es de "+ resultado);
          Console.ReadKey();
          break;
        case 2:
          System.Console.WriteLine("1er numero");
          valor1 = Console.ReadLine();
          System.Console.WriteLine("2do numero");
          valor2 = Console.ReadLine();
          resultado = valor1 - valor2;
          Console.WriteLine("la resta es de" + resultado);
          Console.ReadKey();
          break;
        case 3:
          System.Console.WriteLine("1er numero");
          valor1 = Console.ReadLine();
          System.Console.WriteLine("2do numero");
          valor2 = Console.ReadLine();
          resultado = valor1 * valor2;
          Console.WriteLine("la multiplicacion es de %d", resultado);
          Console.ReadKey();
          break;
        case 4:
          System.Console.WriteLine("1er numero");
          valor1 = Console.ReadLine();
          System.Console.WriteLine("2do numero");
          valor2 = Console.ReadLine();
          resultado = valor1 / valor2;
          Console.WriteLine("la division es de "+ resultado);
          Console.ReadKey();
          break;
      }*/
  }
}
