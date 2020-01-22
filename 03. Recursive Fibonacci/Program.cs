using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFibonacci = int.Parse(Console.ReadLine());
            if (numberFibonacci > 50)
            {
                numberFibonacci = 50;
            }
            else if (numberFibonacci < 1)
            {
                numberFibonacci = 1;
            }          
            int[] oldFib = {1, 1};
            for (int i = 2; i <= numberFibonacci; i++)
            {
                int[] newFib = new int[2];
                newFib[0] = oldFib[1];
                newFib[1] = oldFib[0] + oldFib[1];
                oldFib = newFib;
            }
            Console.WriteLine(oldFib[0]);
        }
    }
}
