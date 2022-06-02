using System;

namespace csharpMethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("What is your name?"); // output
                var name = Console.ReadLine();
                Console.WriteLine("What is your favorite color?"); // output
                var favoriteColor = Console.ReadLine();
                Console.WriteLine("What is your favorite Animal?"); // output
                var favoriteAnimal = Console.ReadLine();
                Console.WriteLine("What is your favorite band?"); // output
                var favoriteBand = Console.ReadLine();
                Console.WriteLine($"My name is {name}. My favorite color is {favoriteColor}. ");

                Add(5, 2);
                Multiply(5, 2);
                Console.WriteLine(Multiply(5, 2));
            }
        }
       
            

    //public static int Add(int num1, int num2)
    //{
    //var answer = num1 + num2;
    //return answer;
    //}
    public static void Add(int num1, int num2)
        {
            var answer = num1 + num2;
            Console.WriteLine(answer);

        }
        public static int Multiply(int num1, int num2)
        { 
            var answer = num1 * num2;
            return answer;
        }
    }
}
