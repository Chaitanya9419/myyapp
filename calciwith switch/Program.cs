using System;

namespace calciwith_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            label:
                int a, b;
                double result;
                string ops;
                string ans;
                Console.WriteLine("value of a:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("value of b:");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("operator:(+,-,*,/)");
                ops = Console.ReadLine();
                switch (ops)
                {
                    case "+":
                        result = a + b;
                        Console.WriteLine(result);
                        break;
                    case "-":
                        result = a - b;
                        Console.WriteLine(result);
                        break;
                    case "*":
                        result = a * b;
                        Console.WriteLine(result);
                        break;
                    case "/":
                        result = a / b;
                        Console.WriteLine(result);
                        break;
                }

             Console.WriteLine("want to continue:[y or n]");
            ans = Console.ReadLine();
            if (ans == "y")
            {
                Console.ReadKey();
                goto label;
            }
            else
            {
                Console.ReadKey();
            }

           
            


          


        }
    }
}
