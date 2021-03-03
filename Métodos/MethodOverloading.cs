using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      NamePets("Laika", "Albert");
      NamePets("Mango", "Puddy", "Bucket");
      NamePets();
    }
    static void NamePets(string a, string b)
    {
      Console.WriteLine($"Your pets {a} and {b} will be joining your voyage across space!");
    }
    static void NamePets(string a, string b, string c)
    {
      Console.WriteLine($"Your pets {a}, {b}, and {c} will be joining your voyage across space!");
    }
    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
  }
}