// Write a C# Code to find the number of character occurence

using System;

Console.WriteLine("Enter a String: ");
string input = Console.ReadLine();

//create an array to store the charatcter count
int[] charcount = new int[256];

//loop through each character in the string and count occurences
#pragma warning disable CS8602 // Dereference of a possibly null reference.
foreach (char c in input)
{
    charcount[c]++;
}
// Display the character
Console.WriteLine("\n characters: ");
for (int i = 0; i < 256; i++)

{
    if(charcount[i]>0){
        
    Console.WriteLine($"{(char)i}: {charcount[i]}");
    }
}
