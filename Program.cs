using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "baku", "qebele", "sheki", "qax", "shamaxi" };
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length>5)
                {
                    Console.WriteLine(words[i]);
                }


                    
            }


            
        }
    }
}
