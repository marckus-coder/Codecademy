using System;

namespace BuiltInMethods
{
  class Program
  {
    static void Main(string[] args)
    {     
      string[] summerStrut;
      
      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };
      
      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

      int position = Array.IndexOf(ratings, 3);
      Console.WriteLine($"Song number {position + 1} is rated three stars");

      string localz = Array.Find(summerStrut, local => local.Length > 10);
      Console.WriteLine($"The first song that has more than 10 characters in the title is {localz}.");

      Array.Sort(summerStrut);
      Console.WriteLine($"First Song: {summerStrut[0]}, Last Song: {summerStrut[7]}");

      
    }
  }
}