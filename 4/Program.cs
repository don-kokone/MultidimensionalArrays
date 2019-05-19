using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int [rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[i] = numbers; 
            }
            string command = Console.ReadLine();

            while ((command = Console.ReadLine()?.ToLower()) != "end")
            {
                string[] tokens = Console.ReadLine().Split();
                string operation = command;
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
                

                if (row < 0 || row >= rows || col < 0 || col >= jaggedArray[row].Length )
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                switch (operation)
                {
                    case "add":
                        jaggedArray[row][col] += value;
                        break;
                    case "substract":
                        jaggedArray[row][col] -= value;
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
