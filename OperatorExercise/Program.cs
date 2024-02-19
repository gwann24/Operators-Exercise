namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Console.WriteLine("Exercise 1\n");
            int a = 17;
            int b = 4;
            int add = a + b;
            int minus = a - b;
            int times = a * b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a} + {b} = {add}.");
            Console.WriteLine($"{a} - {b} = {minus}.");
            Console.WriteLine($"{a} * {b} = {times}.");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            Console.WriteLine("\n\nExercise 2\n");
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius {radius} is {AreaOfCircle(radius)}.");

            Console.WriteLine("\n\nExercise 3\n");
            // var is implicit type inferrence (more on this later)
            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); // ouputs ?
        }
    }
}
