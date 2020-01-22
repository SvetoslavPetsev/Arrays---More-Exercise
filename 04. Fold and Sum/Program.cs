using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int[] first = new int[input.Length / 2];
            int[] second = new int[input.Length / 2];
            for (int i = 0; i < first.Length / 2; i++)
            {
                first[i] = input[(input.Length / 4) - 1 - i];
            }
            for (int j = 0; j < first.Length / 2; j++)
            {
                first[(first.Length / 2) + j] = input[input.Length - 1 - j];
            }
            //Console.WriteLine(string.Join(" ", first));
            for (int k = 0; k <= second.Length - 1; k++)
            {
                second[k] = input[(input.Length / 2) - (second.Length / 2) + k];
            }
            //Console.WriteLine(string.Join(" ", second));
            int[] sum = new int[input.Length / 2];
            for (int f = 0; f < input.Length / 2; f++)
            {
                sum[f] = first[f] + second[f];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
