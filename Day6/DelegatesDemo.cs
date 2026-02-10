using System;

namespace DelegatesDemo
{
    class DelegatesDemoApp
    {
        
        delegate void MathOperation(int a, int b);

        static void Main(string[] args)
        {
           
            MathOperation operation = Subtract;
            operation(10, 3);

            operation = Add;
            operation(10, 3);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is {a + b}");
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine($"The difference of {a} and {b} is {a - b}");
        }
        static void Multiply(int a, int b){
          Console.WriteLine($"The Multiplication of {a} and {b} is {a * b}");
        }
        static void Divide(int a, int b){
          Console.WriteLine($"The Multiplication of {a} and {b} is {a / b}");
        }
    }
}
