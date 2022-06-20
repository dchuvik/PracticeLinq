using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameNames = new List<string>() { "Halo 2", "GTA V", "Super Mario Kart", "Need for Speed", "FIFA 20" };
            var orderedList = videoGameNames.OrderBy(x => x.Length).ToList();

            foreach (var item in orderedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}