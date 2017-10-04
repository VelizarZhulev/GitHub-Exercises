using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine();
            var next = 0;

            while (ingredients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                ingredients = Console.ReadLine();
                next++;
            }
            Console.WriteLine($"Preparing cake with {next} ingredients.");

        }
    }
}
