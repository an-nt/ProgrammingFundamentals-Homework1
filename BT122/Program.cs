using System;

namespace BT122
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] testcase = new float[] { 1.1f, 1.2f, 7 };
            
            Console.WriteLine(FindMaxElement(testcase));
        }

        static float FindMaxElement(float[] Arr)
        {
            if (Arr.Length == 0)
            {
                return 0;
            }
            float max = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] > max)
                {
                    max = Arr[i];
                }
            }
            return max;
        }
    }
}
