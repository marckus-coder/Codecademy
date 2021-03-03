using System;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string ageAsString = "102";
      string nameAsString = "Granny";
      int ageAsInt;
      bool outcome;
//Exercício 03      
      outcome = Int32.TryParse(ageAsString, out ageAsInt);
      Console.WriteLine(outcome);
      Console.WriteLine(ageAsInt);

//Exercício 04
      int nameAsInt;
      bool outcome2;

     outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
      Console.WriteLine(nameAsInt);
      Console.WriteLine(outcome2);


      
    }    
	}
}
