using System;
using System.Linq;
namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main()
        {
            int[] inputArray = Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int seqCounterLenght = 0;
            int bestLeftSeq = 0;
            int[] testArray = new int[inputArray.Length];
            int seqArIndex = 0;
            int point = inputArray[0];
            int[] bestArray = new int[1];
            bestArray[0] = inputArray[0];
            int b = 0;
            for (int j = 0; j < inputArray.Length; j++)
            {
                for (int i = b; i < inputArray.Length; i++)
                {
                    if (inputArray[i] > point)
                    {
                        seqCounterLenght++;
                        point = inputArray[i];
                        testArray[seqArIndex] = point;
                        b = i;
                        seqArIndex++;
                        break;
                    }
                }
            }
            int[] removeEmptyArray = new int[seqCounterLenght];
            int a = 0;
            for (int i = 0; i < removeEmptyArray.Length; i++)
            {
                for (int m = a; m < testArray.Length; m++)
                {
                    if (testArray[m] != 0)
                    {
                        removeEmptyArray[i] = testArray[m];
                        a = m;
                        break;
                    }
                }
            }
            //if (seqCounterLenght > bestLeftSeq)
            //{
            //    bestArray = removeEmptyArray;
            //}
        Console.WriteLine(string.Join(" ", bestArray));
        }
    }
}
