using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(4, 4, 4);
            Vector3 two = new Vector3(1, 2, 3);

            Console.WriteLine($"Static method Add: {Vector3.Add(one, two)}");
            Console.WriteLine($"Object method Add: {one.Add(two)}");
            Console.WriteLine($"Operator overload Add: {one+two}\n");

            Console.WriteLine($"Operator overload subtract: {one - two}\n");

            Console.WriteLine($"Operator overload Scalar Multiplication: {4 * two}");
            Console.WriteLine($"Operator overload Scalar Multiplication(swapped parameters): {one * 4}\n");

            Console.WriteLine($"Operator overload comparison false: {one == two}");
            Console.WriteLine($"Operator overload comparison true: {one == new Vector3(4,4,4)}");
            Console.WriteLine($"Operator overload comparison true: {one != two}\n");

            Console.WriteLine($"Operator overload increment after: {one++}");
            Console.WriteLine($"Operator overload increment before: {++one}\n");

            Console.WriteLine($"Operator overload Magnitude: {~one}");

            if (one)
            {
                Console.WriteLine($"truth: {one}");
            }
            else
            {
                Console.WriteLine($"false: {one}");
            }

            if (Vector3.Zero)
            {
                Console.WriteLine($"truth: {Vector3.Zero}");
            }
            else
            {
                Console.WriteLine($"false: {Vector3.Zero}");
            }

        }
    }
}
