using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Sample
    {
        static void Main()
        {
            int numberInput = int.Parse(Console.ReadLine());
            int[] resultArray = new int[numberInput];
            char[] vowel = {'A', 'a', 'E', 'e', 'O', 'o', 'U', 'u', 'I', 'i'};
            for (int i = 0; i < numberInput; i++)
            {
                string word = Console.ReadLine();
                char[] letter;
                int sum = 0;
                
                letter = word.ToCharArray();
                
                for (int j = 0; j < letter.Length; j++)
                {
                    bool isVowel = false;
                    int number;
                    for (int k = 0; k < vowel.Length; k++)
                    {
                        if (letter[j] == vowel[k])
                        {
                            isVowel = true;
                            break;
                        }        
                    }
                    if (isVowel)
                    {
                        number = letter[j] * letter.Length;
                    }
                    else
                    {
                        number = letter[j] / letter.Length;
                    }
                    sum += number;
                }
                resultArray[i] = sum;
            }                    
            Array.Sort(resultArray);            
            foreach (var a in resultArray)
            {
                Console.WriteLine(a);
            }
        }
    }
}