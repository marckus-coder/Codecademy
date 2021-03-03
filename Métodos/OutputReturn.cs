using System;

namespace Return
{
  class Program
  {
    static string DecoratePlanet(string planet)
    {
      return $"*-*-* Welcome to {planet}";
    }
    static void Main(string[] args)
    {
      DecoratePlanet("Juptier");
      Console.WriteLine(DecoratePlanet("Jupiter"));
      
    }
    
	}
}