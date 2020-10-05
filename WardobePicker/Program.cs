using System;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = { "hat", "hoodie", "jeans", "shirt", "underwear" };
            string[] colors = { "red", "white", "purple", "blue" };
            string[] patterns = { "flowery", "striped", "circles", "checkered" };

            Console.WriteLine("Do you need help picking an outfit?");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "no")
            {
                Console.WriteLine("Farewell.");
            }
            else
            {
                Random rnd = new Random();
                int randomWardrobe = rnd.Next(1, wardrobe.Length);
                int randomColors = rnd.Next(1, colors.Length);
                int randomPatterns = rnd.Next(1, patterns.Length);
                Console.WriteLine($"Today you should wear {colors[randomColors]} {patterns[randomPatterns]} {wardrobe[randomWardrobe]}.");
            }

        }
    }
}