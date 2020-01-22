using System;
using System.Linq;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowNumber = int.Parse(Console.ReadLine());

            int[] pascalArray = {1};

            for (int i = 2; i <= rowNumber + 1; i++)
            {
                int[] newArray = new int[i];
                for (int k = 0; k < pascalArray.Length; k++)
                {
                    if (k == 0 || k == pascalArray.Length - 1)
                    {
                        newArray[k] = 1;
                        continue;
                    }
                    else
                    {
                        newArray[k] = pascalArray[k] + pascalArray[k - 1];
                    }
                }
                pascalArray = newArray;
                for (int f = 0; f < pascalArray.Length - 1; f++)
                {
                    Console.Write(pascalArray[f] + " ");                   
                }
                Console.WriteLine();
            }
        }
    }
}
