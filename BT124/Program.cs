using System;

namespace BT124
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] testcases = new int[][] {
                new int[]{1,2,3,4},
                new int[]{1,3,5,7},
                new int[]{2001,2003},
            };
            for (int i = 0; i < testcases.Length; i++)
            {
                Console.WriteLine(IsExistEvenNumLessThan2004(testcases[i]));
            }
          
        }
        static bool IsExistEvenNumLessThan2004(int[] Arr)
        {
            if (Arr.Length == 0)
            {
                return false;
            }
            for ( int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i]%2==0 && Arr[i] < 2004)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
