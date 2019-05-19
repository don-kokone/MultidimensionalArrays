using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
               .Split(',')
               .Select(int.Parse)
               .ToArray();

            int[,] arr = new int[dim[0], dim[1]];
            

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = tokens[j];
                }

                
            }
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                int sum = 0;

                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum += arr[i, j];
                }

                Console.WriteLine(sum);
                sum = 0;
            }
        }


    }
}
