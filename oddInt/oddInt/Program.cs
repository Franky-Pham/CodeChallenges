using System;

namespace oddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 6, 6, 1, 6, 5};
            int ans  = findOdd(array);
            Console.WriteLine(ans);
        }

        static int findOdd(int[] array)
        {
            for(int i = 0; i<array.Length; i++)
            {
                int counter = 0;
                for (int n = i; n<array.Length; n++)
                {
                    if (array[n] == array[i])
                    {
                        counter += 1;
                    }
                }
                if (counter % 2 != 0)
                {
                return array[i];
                }
            }
            return -1;
        }
    }
}
//Write a function that:
//Given an array of integers, find the one that appears an odd number of times.
//There will always be only one integer that appears an odd number of times.