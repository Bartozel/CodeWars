using System;

namespace CodeWars
{
    class Program
    {
        static void Main()
        {
            int[][] array_1 =
            {
                new int[] { 1,2,3},
                new int[] { 4,5,6},
                new int[] { 7,8,9}
            };

            var result1 = SnailSort.Snail(array_1);
            Console.WriteLine(String.Join(", ", result1));

            int[][] array_2 =
{
                new int[] { 1,2,3},
                new int[] { 8,9,4},
                new int[] { 7,6,5}
            };

            var result2 = SnailSort.Snail(array_2);
            Console.WriteLine(String.Join(", ", result2));
            Console.ReadKey();
        }
    }
}