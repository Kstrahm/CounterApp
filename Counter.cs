using System;

namespace Counter.ProgramTime
{
  class Program
  {
      static void Main()
      {
          // Prompt user for minutes exercised 
          Console.Write("Enter how many minutes you programmed: ");
        
          string entry = Console.ReadLine();
        
 
          // Add minutes exercised to total           
          // Display total minutes exercised to the screen 
          Console.WriteLine("You've entered " + entry +  " minutes");
        
          // Repeat until user quits    
      }
  }
}