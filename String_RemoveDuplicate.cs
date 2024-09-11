using System;

namespace  hey
{
  class Program
  {
    static void removeduplicateChar()
    {
        string s = "theDOTNEToffice";
        s = s.ToUpper();
        string newstring = string.Empty; //
        List<char> found = new List<char>();
        foreach(char c in s){
            if(found.Contains(c))
            continue;

            newstring+= c.ToString();
            found.Add(c);
        }
        Console.WriteLine("output is -" + newstring);
        Console.ReadLine();


       
    }
  }
}