
//Problem of the Day:
// Birthday Cake Candles

// Task:
// Count how many candles are the tallest.

// Description:
// You are given a list of integers representing the height of each candle. You need to determine how many candles are the tallest.

// Example:
// If candles = [4, 1, 4, 3],
// the tallest candles are 4 units high,
// and there are 2 candles with this height.

// So, the function should return 2.

// Input:
// A list of space-separated integers representing candle heights.

// Sample Inputs and Outputs:


// Input	Output
// 4 1 4 3	2
// 3 2 1 3	2
// 1 2 3 4 5 5	2
// 7	1
// Return:
// The number of candles that are the tallest.
﻿using System.Reflection;
namespace ProplemOfAday
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
                int[] candles = new int[4] {4, 4, 5, 5};
                int tallest = candles[0];
                int count = 0;

                for (int i = 0; i < candles.Length; i++)
                    {
                        if (candles[i] > tallest)
                        {
                            tallest = candles[i];
                        } 
                    }

                for (int i = 0; i < candles.Length; i++)
                {
                    if (candles[i] == tallest)
                    {
                        count++;
                    }
                }
                Console.WriteLine("Number of tallest candles = " + count);
            }
        }

    }

