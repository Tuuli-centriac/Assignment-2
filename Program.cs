using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment_centria
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string[] lines = File.ReadAllLines("animals.csv");
            foreach (string line in lines)
            {
                string[] pieces = line.Split(",");
                string v = pieces[0];
                string animal = v;
                Console.WriteLine(animal);
            }
        }
    }

  
}
