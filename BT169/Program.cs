using System;

namespace BT169
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(FindTheSmallestEvenNumber(testcase));
        }

        //Return the smallest even number which is larger than any array element
        static int FindTheSmallestEvenNumber(int[] Arr) 
        {
            if (Arr.Length == 0) {
                return 0;
            }
            int max = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > max)
                {
                    max = Arr[i];
                }
            }
            if (max%2 == 0)
            {
                return max + 2;
            }
            else
            {
                return max + 1;
            }
        }
    }
}
