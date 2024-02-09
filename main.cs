using System;
class Program {
  
  static void Main (string[] args) 
  {
    Console.WriteLine("Enter Philippine Bank Note Denomination: ");
    string userInput = Console.ReadLine();
    if (userInput == "1")
    {
      Console.WriteLine("Jose Rizal is found in Php. 1");
    }
      else if (userInput == "5")
    {
      Console.WriteLine("Emilio Aguinaldo is found in Php. 5");
    }
      else if (userInput == "5")
    {
      Console.WriteLine("Emilio Aguinaldo is found in Php. 5");
    }
    else if (userInput == "10")
    {
      Console.WriteLine("Andres Bonifacio, Apolinario Mabini is found in Php. 10");
    }
    else if (userInput == "20")
    {
      Console.WriteLine("Manuel L. Quezon is found in Php. 20");
    }
    else if (userInput == "50")
    {
      Console.WriteLine("Sergio Osmena is found in Php. 50");
    }
    else if (userInput == "100")
    {
      Console.WriteLine("Manuel Roxas is found in Php. 100");
    }
    else if (userInput == "500")
    {
      Console.WriteLine("Benigno Sr. and Corazon Aquino is found in Php. 500");
    }
    else if (userInput == "1000");
    {
      Console.WriteLine("Jose Abad Santos, Vicente Lim, Josefa Llanes Escoda is found in Php. 1000");
    }
    else
    {
      Console.WriteLine($"No person found for denomination: {userInput}");
    }
  }
}    