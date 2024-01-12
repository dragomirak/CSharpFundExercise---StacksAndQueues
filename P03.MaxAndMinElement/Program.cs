﻿namespace P03.MaxAndMinElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int command = data[0];

                if (command == 1)
                {
                    stack.Push(data[1]);
                }
                else if (command == 2)
                {
                     stack.Pop();
                }
                else if (command == 3 && stack.Count > 0) 
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command == 4 && stack.Count > 0) 
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}