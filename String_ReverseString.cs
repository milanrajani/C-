 using System;

namespace HelloWorld
{
  class Program
  {
    static void Reverse()
    {
      Console.WriteLine("Enter the Sting: ");
      string input = Console.ReadLine();
      string result = " ";

      for (int i = input.Length - 1; i>=0; i--) {
            result = result + input[i];
      }   
      Console.WriteLine(result);
    }
  }
}