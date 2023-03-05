namespace MethodsExercise
{
    public class Program
    {
            //-------------------Exersise 2----------------------------------------
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);

            //-------------------Exersise 1----------------------------------------
            
            Console.WriteLine("Hello, what is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Cool, the {animal} is such a fascinating creature.  What is you favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}!  Here is your profile!");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine($" Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

       
        }
    }
}
