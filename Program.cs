using System;

namespace myCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter another number: ");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter an operation:");
            Console.Write("+ -> addition, - -> subtraction, * -> multiplication, / division ");
            char opt = Convert.ToChar(Console.ReadLine());
            switch (opt){
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", first, second, (first + second));
                    break;
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", first, second, (first - second));
                    break;
                case '*':
                    Console.WriteLine("{0} * {1} = {2}", first, second, (first * second));
                    break;
                case '/':
                    if (second == 0){
                        Console.WriteLine("Error: You're trying to divide by 0.");
                    }
                    else{
                        Console.WriteLine("{0} / {1} = {2}", first, second, (first / second));
                    }
                    break;
                default:
                    Console.WriteLine("You may have chosen wrong operation.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
