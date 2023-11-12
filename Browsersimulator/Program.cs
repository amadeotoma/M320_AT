using System;

namespace Browsersimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringStack stack = new StringStack(5);

            stack.Push("Value1");
            stack.Push("Value2");
            stack.Push("Value3");

            string topValue = stack.Peek();
            Console.WriteLine($"Top value auf dem Stack: {topValue}");

            string poppedValue = stack.Pop();
            Console.WriteLine($"Value wurde vom Stack gepoppt: {poppedValue}");

            stack.Swap();

            Console.WriteLine("Die übrigen Elemente im Stack sind:");
            while (!stack.IsEmpty)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}