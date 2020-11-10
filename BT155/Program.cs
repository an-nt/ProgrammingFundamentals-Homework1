using System;

namespace BT155
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testcase = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9,-1 };
            Console.WriteLine(FindTheFarthestElementFromX(testcase, 7));
        }
        static int FindTheFarthestElementFromX(int[] Arr, int x) //Find index
        {
            int index = -1;
            if (Arr.Length == 0)
            {
                return index;
            }
            index = 0;
            int maxdistance = Math.Abs(Arr[0] - x);
            for (int i = 0; i < Arr.Length; i++)
            {
                if(Math.Abs(Arr[i]-x) > maxdistance)
                {
                    maxdistance = Math.Abs(Arr[i] - x);
                    index = i;
                }
            }
            return index;
      
        }
    }
}
