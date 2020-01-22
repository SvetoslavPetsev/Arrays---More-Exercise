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


            int bestLeftSeq = 0;                                 
            int[] bestArray = new int[1];
            bestArray[0] = inputArray[0];
            for (int k = 0; k < inputArray.Length; k++)
            {
                int seqCounterLenght = 0;
                int seqArIndex = 0;
                int pointContent = inputArray[k];
                int pointIndex = k;
                int[] testArray = new int[inputArray.Length];
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int i = pointIndex; i < inputArray.Length; i++)
                    {
                        if (inputArray[i] > pointContent)
                        {
                            seqCounterLenght++;
                            testArray[seqArIndex] = pointContent;
                            pointContent = inputArray[i];
                            seqArIndex++;
                            break;
                        }
                        else if (i == inputArray.Length - 1)
                        {
                            testArray[seqArIndex] = pointContent;
                        }
                    }
                }
                bestArray = testArray;
                Console.WriteLine(string.Join(" ", bestArray));
            }            
        }
    }
}