using System;

namespace CalculationsMethods
{
    class Program
    {
        static double Addition(double a, double b)
        {
            double sum =  a + b;
            return sum;
        }
        static double Subtraction(double a, double b)
        {
            double difference = a - b;
            return difference;
        }
        static double Multiplication(double a, double b)
        {
            double product = a * b;
            return product;
        }
        static double Division(double a, double b)
        {
            double quotient = a / b;
            return quotient;
        }
        static void Main(string[] args)
        {
            double a, b;
            string reset = "N";
            string answer;

            do
            {
                Console.WriteLine("What calculation do you wish to perform? \n1.Add\n2.Subtract\n3.Multiply\n4.Divide");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Enter the first number:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second number:");
                        b = double.Parse(Console.ReadLine());
                        double c = Addition(a, b);
                        Console.WriteLine("The sum of the numbers is: " + c);
                        break;
                    case "2":
                        Console.WriteLine("Enter the first number:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second number:");
                        b = double.Parse(Console.ReadLine());
                        double d = Subtraction(a, b);
                        Console.WriteLine("The difference of the numbers is: " + d);
                        break;
                    case "3":
                        Console.WriteLine("Enter the first number:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second number:");
                        b = double.Parse(Console.ReadLine());
                        double e = Multiplication(a, b);
                        Console.WriteLine("The product of the numbers is: " + e);
                        break;
                    case "4":
                        Console.WriteLine("Enter the first number:");
                        a = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second number:");
                        b = double.Parse(Console.ReadLine());
                        double f = Division(a, b);
                        Console.WriteLine("The quotient of the numbers is: " + f);
                        break;
                }
                Console.WriteLine("Would you wish to perform another calculation?");
                reset = Console.ReadLine();


            }
            while (answer == "Y");
        }
    }
}
