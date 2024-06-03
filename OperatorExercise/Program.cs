namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            int a = 17;
            int b = 4;
            int sum = a + b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}\n" +
                $"{a} / {b} is {quotient}\n" +
                $"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine();

            //Exercise 2
            AreaOfCircle();

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        public static double AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine();
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}\n");
            return area;
        }
    }
}
