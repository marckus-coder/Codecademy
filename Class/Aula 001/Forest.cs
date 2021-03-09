using System;

namespace BasicClasses
{
  class Forest
  {
    public int age; // Campo
    public string biome; // Campo
    
    public string Name { get; set; }
    public int Trees { get; set;}
    public string Biome // Propriedade do campo biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }

    public int Area //propriedade do campo area
    {
      get {return area;}
      private set{area = value;}
    }
  }

}
