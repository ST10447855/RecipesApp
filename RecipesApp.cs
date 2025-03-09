using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RecipesApp
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Recipe Entry System!");

            // Get number of ingredients
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
            List<Ingredient> ingredients = new List<Ingredient>();

            // Collect ingredients details
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter details for ingredient {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();

                ingredients.Add(new Ingredient(name, quantity, unit));
            }

            // Get number of steps
            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            List<string> steps = new List<string>();
           // Collect step descriptions
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter description for step {i + 1}:");
                steps.Add(Console.ReadLine());
            }

            // Display the complete recipe
            Console.WriteLine("\nRecipe Details:");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"Step {i + 1}: {steps[i]}");
            }
        }
    }

    class Ingredient
    {
        public string Name { get; }
        public double Quantity { get; }
        public string Unit { get; }

        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }

}
    

