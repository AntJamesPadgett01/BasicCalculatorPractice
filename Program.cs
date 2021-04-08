using System;

namespace BasicCalculatorPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("43" + "56"); // only concatenates into "4356"

            int num = Convert.ToInt32 ("45");//Converts string to interger- has to have a NUMBER vs spelling of number
            Console.WriteLine(num + 6);

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);








        }
    }
}
