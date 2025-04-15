using System.Reflection;

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

