using System;

namespace _07CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredientsCount = 0;            
            while (true) 
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    break;
                }
                
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredientsCount++;
            }
            
            Console.WriteLine($"Preparing cake with {ingredientsCount} ingredients.");
        }
    }
}
