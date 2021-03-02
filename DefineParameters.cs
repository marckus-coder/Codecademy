using System;

namespace DefineParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(6);
      VisitPlanets(8);
      //argumentos do parâmetro

    }
    
    static void VisitPlanets(int numberOfPlanets)
    /* Método VisitPlanets, com o parâmetro numberOfPlanets de tipo inteiro.
    */
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
      //chamar parâmetro
    }
  }
}