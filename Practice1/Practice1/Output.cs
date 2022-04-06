using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Output
    {
        public static void parameter(int num1, int num2, out int add, out int sub, out int mul, out float div)
        {
            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = (float)num1 / num2;
        }
        static void Main(string[] args)
        {
            int num1, num2;
            int add, sub, mul;
            float div;

            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Output.parameter(num1, num2, out add, out sub, out mul, out div);

            Console.WriteLine("\n\n{0} + {1} = {2}", num1, num2, add);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, sub);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, mul);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, div);

            Console.ReadLine();

        }
    }
}
 