using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] jaggedAray = new int[size][];
            int cols = 1;

            for (int i = 0; i < size; i++)
            {
                jaggedAray[i] = new int[cols];
                jaggedAray[i][0] = 1;
                jaggedAray[i][cols - 1] = 1;

                if (cols > 2)
                {
                    int[] previousRow = jaggedAray[i - 1];

                    for (int j = 1; j < cols - 1; j++)
                    {
                        jaggedAray[i][j] = previousRow[j] + previousRow[j - 1];
                    }
                }

                cols++;
            }
            foreach (var item in jaggedAray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
