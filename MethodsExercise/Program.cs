namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Cool, the {animal} is such a fascinating creature.  What is you favorite band?");
            var band = Console.ReadLine();
        }
    }
}
