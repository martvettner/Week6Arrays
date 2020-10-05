using System;

namespace Week6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = { "win million", "lose your smartphone", "fall in love", "buy new pc", "move out of my parents house" };
            //today you will...
            Random rnd = new Random();
            int randomindex = rnd.Next(0, predictions.Length);
            Console.WriteLine($"today you will {predictions[randomindex]}");





        }
    }
}
