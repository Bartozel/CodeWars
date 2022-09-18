/*
https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1
Snail Sort

Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

array = [[1,2,3],
         [4,5,6],
         [7,8,9]]
snail(array) #=> [1,2,3,6,9,8,7,4,5]

For better understanding, please follow the numbers of the next array consecutively:

array = [[1,2,3],
         [8,9,4],
         [7,6,5]]
snail(array) #=> [1,2,3,4,5,6,7,8,9]

 * */


using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    internal static class SnailSort
    {
        enum Direction
        {
            right,
            left,
            up,
            down,
        }

        public static int[] Snail(int[][] array)
        {
            var result = new List<int>();
            Direction direction = Direction.right;
            int indexesInOneDirection = array.Length;
            int actualIndex = 0;
            int row = 0;
            int column = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[i].Length; j++)
                {
                    int value = array[row][column];
                    result.Add(value);
                    actualIndex++;

                    if (actualIndex == indexesInOneDirection)
                    {
                        direction = ChangeDirection(direction);
                        indexesInOneDirection = GetIndexesInOneDirection(direction, indexesInOneDirection);
                        actualIndex = 0;
                    }

                    switch (direction)
                    {
                        case Direction.right: column++; break;
                        case Direction.left: column--; break;
                        case Direction.down: row++; break;
                        case Direction.up: row--; break;
                    }
                }
            }

            return result.ToArray();
        }

        private static int GetIndexesInOneDirection(Direction direction, int indexesInOneDirection)
        {
            switch (direction)
            {
                case Direction.down:
                case Direction.up:
                    return indexesInOneDirection - 1;
                default: return indexesInOneDirection;
            }
        }

        private static Direction ChangeDirection(Direction direction)
        {
            switch (direction)
            {
                case Direction.right: return Direction.down;
                case Direction.down: return Direction.left;
                case Direction.left: return Direction.up;
                case Direction.up: return Direction.right;
                default: return direction;
            }
        }
    }
}
