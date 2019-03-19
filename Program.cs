using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Clase_1
{
  class Program
  {
    static void Main(string[] args)
    {
      int ejercicio;
      Console.WriteLine("Que ejercicio quiere ver: ");
      Console.WriteLine("1.");
      if(int.TryParse(Console.ReadLine(),out ejercicio))
      {
        switch(ejercicio)
        {
          case 1:
            ejercicio1();
            break;
        }
      }
    }
    static void ejercicio1()
    {
      int acumulador[4];
      for(int i=0;i<5;i++)
      {
        acumulador[i] = i;
      }
    }
  }
}
